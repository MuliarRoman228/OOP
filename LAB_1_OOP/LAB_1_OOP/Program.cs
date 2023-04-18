using LAB_1_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Files
{
    public string name;
    public int size;
    DateTime dateTime;

    public string GetName()
    {
        return name;
    }

    public int GetSize()
    {
        return size;
    }

    public DateTime GetDateTime()
    {
        return dateTime;
    }

}

static void Main(string[] args)
{
    Files files = new Files();
    files.name = "Petro";
    Console.WriteLine(files.GetName());
    Console.WriteLine("kdlsdkfjdlsgfjjlsd");
}