using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ejercicio5
{
    class Datos
    {
        public static List<Cliente> clientes = new List<Cliente>();
        public static void cargarSerializer()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cliente>));
            TextWriter textWriter = new StreamWriter("clientes.xml");
            serializer.Serialize(textWriter, clientes);
            textWriter.Close();
        }
        public static void cargarDeserializar()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Cliente>));
            TextReader textReader = new StreamReader("clientes.xml");
            clientes = (List<Cliente>)deserializer.Deserialize(textReader);
            textReader.Close();
        }
    }
}
