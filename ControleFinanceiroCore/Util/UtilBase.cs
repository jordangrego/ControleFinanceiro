using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleFinanceiroCore.Entities;
using System.Xml.Serialization;
using System.IO;
using ControleFinanceiroCore.Enums;
using ControleFinanceiroCore.Exceptions;

namespace ControleFinanceiroCore.Util
{
    public static class UtilBase
    {
        public static Base RecuperaBase(byte[] arquivo)
        {
            try
            {
                // Realiza a importação.
                Base baseLancamento = new Base();
                XmlSerializer x = new XmlSerializer(baseLancamento.GetType());
                Stream stream = new MemoryStream(arquivo);
                StreamReader leitor = new StreamReader(stream);

                baseLancamento = (Base)x.Deserialize(leitor);
                leitor.Close();
                return baseLancamento;
            }
            catch (System.Exception)
            {
                throw new ControleFinanceiroCoreException(ControleFinanceiroEnumErro.ERRO_LEITURA_BASE);
            }
        }

        public static void GravarBase(Base baseLancamento, string pathArquivo)
        {
            XmlSerializer x = new XmlSerializer(baseLancamento.GetType());
            StreamWriter escritor = new StreamWriter(pathArquivo);
            x.Serialize(escritor, baseLancamento);
            escritor.Close();
        }

        public static void GravarBase(Base baseLancamento)
        {
            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";
            XmlSerializer x = new XmlSerializer(baseLancamento.GetType());
            StreamWriter escritor = new StreamWriter(pathArquivoBase);
            x.Serialize(escritor, baseLancamento);
            escritor.Close();
        }

        public static Base RecuperarBase()
        {
            string pathArquivoBase = AppDomain.CurrentDomain.BaseDirectory + "\\Base.xml";

            FileStream fs = null;
            try
            {
                fs = File.OpenRead(pathArquivoBase);
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, Convert.ToInt32(fs.Length));
                return RecuperaBase(bytes);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }

        }
    }
}
