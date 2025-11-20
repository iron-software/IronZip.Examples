***Based on <https://ironsoftware.com/examples/create-tar/>***

Tar, an acronym for "Tape Archive," is widely used in Unix and Linux environments as an archiving tool that lets users consolidate several files and directories into a single archive file. This utility has the advantage of not compressing the data, thus retaining original file structures and metadata. It is commonly paired with compression tools like gTar or bTar2 to produce compressed archives. These are especially useful for tasks such as data backup and the distribution of software.

IronZip simplifies this process, enhancing accuracy and efficiency. By automating these tasks, we reduce human error and make workflows more sustainable and easier to manage.

<div class="examples__featured-snippet">
    <h2>The 5 Steps to Creating a TAR File with C&num;</h2>
    <ol>
        <li>using IronZip;</li>
        <li>using (var archive = new IronTarArchive())</li>
        <li>archive.Add("./assets/image1.jpg");</li>
        <li>archive.Add("./assets/example.pdf");</li>
        <li>archive.SaveAs("output.tar");</li>
    </ol>
</div>

### Creating an Empty Tar Archive

To begin, we need to import the `IronZip` namespace, which allows us to use its features. We then proceed to create an empty Tar archive by initializing the `IronTarArchive` within a `using` block.

### Adding Files to the Empty Archive

Before the archive is sealed, files can be added through the `Add` method by specifying their absolute paths. This utility provides the flexibility to add various file types to your archive, from multimedia files like MP3s and WAVs to documents such as DOCX and PDF, and even other Tar files. This feature also allows for nesting compressed archives within each other.

For a comprehensive list of file formats that can be included in the archive, please visit the documentation [here](https://ironsoftware.com/csharp/zip/).

### Saving and Exporting it

The archive is saved and finalized using the `SaveAs` method, with the file being named `output.tar`.

<a href="https://ironsoftware.com/csharp/zip/tutorials/create-read-extract-zip/" class="code_content__related-link__doc-cta-link">Discover More in Our Zip File Creation & Extraction Guide</a>