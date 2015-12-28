using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ControleFinanceiroCore.Ofx
{
    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ConversorExcel
    {
        public DataSet ImportarArquivoExcel(string pathLocalizacaoArquivo)
        {
            OleDbConnection oledbConn = null;
            try
            {
                if (Path.GetExtension(pathLocalizacaoArquivo).ToUpper() == ".XLS")
                {
                    oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + pathLocalizacaoArquivo + "; Extended Properties=\"Excel 8.0;HDR=No;IMEX=2\"");
                }
                else if (Path.GetExtension(pathLocalizacaoArquivo).ToUpper() == ".XLSX")
                {
                    oledbConn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + pathLocalizacaoArquivo + "; Extended Properties='Excel 12.0;HDR=No;IMEX=1;';");
                }

                oledbConn.Open();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                DataSet ds = new DataSet();

                DataTable columnDetails = oledbConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Columns, null);

                string nomePlanilha = columnDetails.Rows[0]["TABLE_NAME"].ToString();

                cmd.Connection = oledbConn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [" + nomePlanilha + "]";
                oleda = new OleDbDataAdapter(cmd);
                oleda.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                throw new ControleFinanceiroCore.Exceptions.ControleFinanceiroCoreException(Enums.ControleFinanceiroEnumErro.ERRO_LEITURA_EXCEL, ex);
            }
            finally
            {
                oledbConn.Close();
            }
        }
    }
}
