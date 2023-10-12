using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UserCredentials modelidan foydalaning ( id, password, userId )


string satr = "satr ustun katakcha";
string[] massiv = satr.Split(' ');
foreach (string a in massiv)
    Console.WriteLine(a);

/* output: 
satr
ustun
katakcha
*/