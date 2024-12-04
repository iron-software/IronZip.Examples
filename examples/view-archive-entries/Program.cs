using IronZip;
using System;
using System.Collections.Generic;

// Open existing ZIP
using (var archive = new IronZipArchive("existing.zip"))
{
    // Get Entries list
    List<Entry> entries = archive.Entries();
    foreach (Entry entry in entries)
    {
        Console.WriteLine(entry.Name);
          }
}
