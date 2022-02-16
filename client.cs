using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chatapp1
{
    public class Client
    {
        public Client()
        {
        }
        public class Details()
            {
            }

    public long ph_num { get; set; }
    public string name { get; set; }

}
public class contact_list
{
    List<string> cli = new List<string>();
    string a = "Sunny";
    string b = "raju";
    string c = "Gireesh";
    string d = "roy";
    public void list()
    {
        cli.Add(a);
        cli.Add(b);
        cli.Add(c);
        cli.Add(d);
    }
    public void group()
    {
        cli.Remove(a);

    }

}
}

public class Options
{
    List<string> con = new List<string>();
    public void Add()
    {
        Console.WriteLine("Create  or add contacts?");

        string n1 = Console.ReadLine();
        con.Add(n1);
        Console.WriteLine(con);
        Console.Read();


    }
    public void view()
    {
        Console.WriteLine("Hi ");
        Console.Read();

    }
    public void edit()
    {

    }
    public void delete()
    {

    }
}