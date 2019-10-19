using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace HimeRun {
    class SQLiteHelper {

        private SQLiteConnection Connection;

        public SQLiteHelper(string dbPath, string dbName) {
            if (!Directory.Exists(dbPath)) {
                throw new Exception($"Cannot setup or read your database from { dbPath }.");
            }
            Connection = new SQLiteConnection("data source=" + dbPath + @"\" + dbName + ";version=3;");
            try {
                Connection.Open();
            } catch (Exception ex) {
                throw ex;
            }
        }
        public void Close() {
            Connection.Close();
        }
        /// <summary>
        /// execute an sql
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public SQLiteDataReader Execute(string SQL, bool readResult = false) {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = Connection;
            cmd.CommandText = SQL;
            if (readResult) return cmd.ExecuteReader();
            try {
                cmd.ExecuteNonQuery();
            } catch { }
            return null;
        }

        public List<string[]> ExecuteToList(string SQL) {
            SQLiteDataReader rs = Execute(SQL, true);
            List<string[]> result = new List<string[]>();
            int fieldsCount = rs.FieldCount;
            while (rs.Read()) {
                List<string> line = new List<string>();
                for (int i = 0; i < fieldsCount; i++) {
                    string fileType = rs.GetFieldType(i).ToString();
                    try {
                        switch (fileType) {
                            default:
                                line.Add("");
                                break;
                            case "System.String":
                                line.Add(rs.GetString(i));
                                break;
                            case "System.Int32":
                                line.Add(rs.GetInt32(i).ToString());
                                break;
                            case "System.Int16":
                                line.Add(rs.GetInt16(i).ToString());
                                break;
                            case "System.Int64":
                                line.Add(rs.GetInt64(i).ToString());
                                break;
                            case "System.DateTime":
                                line.Add(rs.GetDateTime(i).ToString());
                                break;
                        }
                    } catch {
                        line.Add("");
                    }
                }
                result.Add(line.ToArray());
            }
            return result;
        }

        public string GetOneLine(string SQL) {
            List<string[]> queryResult = ExecuteToList(SQL);
            if (queryResult.Count < 1) {
                return null;
            }
            if (queryResult[0].Length < 1) {
                return null;
            }
            if (queryResult[0].Length < 2) {
                return queryResult[0][0];
            }
            return String.Join(";", queryResult[0]);
        }
    }
}
