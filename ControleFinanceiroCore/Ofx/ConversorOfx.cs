using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Xml;

namespace ControleFinanceiroCore.Ofx
{
    /// <summary>
    /// Classe de Conversão de Arquivos OFX para DataSet.
    /// </summary>
    public class ConversorOfx
    {
        public DataSet ToDataSet(string path1)
        {

            DataSet ds = new DataSet();

            if (!System.IO.File.Exists(path1))
            {
                throw new FileNotFoundException("Arquivo não achado", path1);
            }

            if (path1.Substring(path1.Length - 3, 3).ToLower() != "ofx")
            {
                throw new Exception("Arquivo Inválido");
            }


            //executa Pesquisas pelo caractere '<' e adiciona um 'enter' antes dele
            //vbcrlf
            //Dim arquivo As File
            //arquivo.Open(path1)

            //Dim concat As New System.Text.StringBuilder
            //Dim str As String = "meu irmao tem problemas mentais graves"
            //For Each x As Char In str
            //    concat.Append(x)
            //    If x = "a" Then
            //        concat.Append(vbCrLf)
            //    End If
            //Next
            //Console.Write(concat)
            //Console.Read()




            System.IO.StreamReader oRead = null;
            string EntireFile = null;
            oRead = File.OpenText(path1);
            EntireFile = oRead.ReadToEnd();
            oRead.Close();

            System.Text.StringBuilder concat = new System.Text.StringBuilder();

            foreach (char x in EntireFile)
            {
                if (x == '<')
                {
                    concat.Append("\r\n");
                }
                concat.Append(x);
            }

            //EntireFile.Replace("<", Environment.NewLine & "<")

            System.IO.StreamWriter oWriter = new System.IO.StreamWriter(path1);
            oWriter.Write(concat);
            //oWriter.Write("a")
            oWriter.Close();

            StreamReader tr = new StreamReader(path1);
            string Linha = tr.ReadLine();
            System.Text.StringBuilder final = new System.Text.StringBuilder();
            string input = null;
            //final.Append("<dados>")
            input = tr.ReadLine();
            while (input.ToUpper() != "</OFX>")
            {
                //verifica se inicia o Append, o Append só deve ser Iniciado após o input ser igual a <OFX>
                if ((input.IndexOf("<") != -1 | input.IndexOf(">") != -1))
                {
                    string Pedaco = acha_tag(input.Replace("<NAME>", "<MEMO>").Trim());
                    final.Append(Pedaco);
                }
                input = tr.ReadLine();
            }

            tr.Close();
            tr.Dispose();
            //final.Append("</dados>")
            System.IO.StringReader xmlSR = new System.IO.StringReader(final.ToString());

            ds.ReadXml(xmlSR);

            return ds;
        }

        private string acha_tag(string strTag)
        {

            string procura = null;
            string fecha = null;
            string[] vet = null;
            string[] vetFecha = null;
            string strTemp = null;
            int tagFim = 0;
            procura = "<TRNTYPE>;<DTPOSTED>;<TRNAMT>;<CHECKNUM>;<MEMO>;<TRNTYPE>;<DTPOSTED>;<TRNAMT>;<FITID>;<CHECKNUM>;";
            fecha = "</TRNTYPE>;</DTPOSTED>;</TRNAMT>;</CHECKNUM>;</MEMO>;</TRNTYPE>;</DTPOSTED>;</TRNAMT>;</FITID>;</CHECKNUM>;";
            vet = procura.Split(';');
            vetFecha = fecha.Split(';');

            strTemp = separa_tag(strTag.Replace("<NAME>", "<MEMO>").Replace("</NAME>", "</MEMO>"));

            if ((strTag.Length > 0))
            {

                if ((procura.IndexOf(strTemp) != -1))
                {
                    tagFim = procura_vetor(vet, strTemp);
                    //replaces invalid xml caracters on the ofx files
                    strTag = strTag.Replace("&", "-");
                    strTag = strTag.Replace("/", "-");
                    return strTag + vetFecha[tagFim];
                }
                else if ((strTag == "<BANKTRANLIST>" | strTag.ToUpper() == "</BANKTRANLIST>" | strTag.ToUpper() == "</STMTTRN>" | strTag.ToUpper() == "<STMTTRN>"))
                {
                    return strTag;
                }
            }
            return "";
        }

        private int procura_vetor(string[] vet, string procura)
        {
            int i = 0;
            for (i = 0; i <= vet.Length; i++)
            {
                if ((vet[i].ToUpper().Equals(procura.ToUpper())))
                {
                    return i;
                }
            }
            return 0;
        }

        private string separa_tag(string tag)
        {
            int pos_ini = 0;
            int pos_fim = 0;
            pos_ini = tag.IndexOf("<");
            pos_fim = tag.IndexOf(">");
            pos_fim = pos_fim - pos_ini;
            return tag.Substring(pos_ini, pos_fim + 1);
        }
    }
}
