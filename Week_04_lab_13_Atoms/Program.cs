using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;


namespace Week_04_lab_13_Atoms
{
    public class Program
    {
        //calling all static method to the main
        static void Main(string[] args)
        {
            List<Atom> atoms = Atom.GetAtoms();

            Atom.DisplayElements(atoms);

            Atom.WriteJsonFirstItem(atoms[0], "JsonFirstItem.json"); //writing only the first item to the json file
            Atom.ReadJsonFirstItem("JsonFirstItem.json");

            Atom.WriteXMLFirstItem(atoms[0], "XMLFirstItem.xml"); //writing only the first item to the xml file
            Atom.ReadXMLFirstItem("XMLFirstItem.xml");

            Atom.WriteJson(atoms, "JsonAll.json");
            Atom.WriteXMLAllItems(atoms, "XMLAll.xml");

            Atom.ReadJson("JsonAll.json");
            Atom.ReadXMLAllItems("XMLAll.xml");

            Console.ReadKey();
        }
    }
}
