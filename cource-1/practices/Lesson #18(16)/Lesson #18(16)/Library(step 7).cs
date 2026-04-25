using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;
public class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}