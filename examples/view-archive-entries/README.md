***Based on <https://ironsoftware.com/examples/view-archive-entries/>***

When working with archive files, developers often find it beneficial to inspect archive contents without fully extracting them first. This is particularly useful when simply confirming the presence of specific entries, as full extraction can sometimes be resource-intensive. IronZIP provides capabilities that allow you to preview the contents inside an archive, which enhances efficiency and enables quick verification and inspection of files before deciding to extract them.

Here, we will delve into how to employ the **Entry** class in conjunction with the **IronZipArchive** to generate and display a list of the entries in an archive without needing to extract them first.

<div class="examples__featured-snippet">
    <h2>Preview Archive Entries using C&num;</h2>
    <ol>
        <li>`using IronZip;`</li>
        <li>`using (var archive = new IronZipArchive("existing.zip"))`</li>
        <li>`List<Entry> entries = archive.Entries();`</li>
        <li>`foreach (Entry entry in entries)`</li>
        <li>`Console.WriteLine(entry.Name);`</li>
    </ol>
</div>

### Loading an Existing Archive

Initially, integrate the namespace **IronZip**. Then, create an instance of `IronZipArchive` using a directory path to a ZIP file as the parameter to access the archive's contents.

#### Reviewing Archive Content

Once the ZIP file is loaded, employ the capabilities of **IronZipArchive** to access a summary list of all entries contained within the archive. The **Entries** method of the **IronZipArchive** returns a collection, specifically a `<List>` consisting of **Entry** objects from the archive.

#### Entry Attributes

Each **Entry** object encompasses a set of properties such as **name**, **size**, **version**, along with additional attributes like **comments** and the encryption methodology used for its creation. This example demonstrates iterating over this list with a for loop, printing the names of all entries, which highlights the practicality of viewing contents without the need for extraction. For further details on properties available in the **Entry** class, you can refer to [this page](https://ironsoftware.com/csharp/zip/object-reference/api/IronZip.Entry.html).

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/" class="code_content__related-link__doc-cta-link">Discover How to Create, Read & Extract ZIP Files Using IronZip</a>