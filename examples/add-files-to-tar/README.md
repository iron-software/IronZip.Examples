***Based on <https://ironsoftware.com/examples/add-files-to-tar/>***

Here's a paraphrased version of the article, with hyperlinks and images resolving to `ironsoftware.com`:

---

The following code snippet shows how to access an existing TAR archive and export it to a new TAR file using IronZip.

IronZip is equipped with functionality that allows for altering existing TAR files, which proves extremely useful for managing archives in C# applications. Begin with the `FromFile` method to gain access to the archive you intend to alter.

After opening the archive, take advantage of the `Add` method to include additional files into the archive. This capability greatly eases the task of expanding and updating your zip archives, accommodating the changing requirements of your projects seamlessly.

To finalize, employ the `SaveAs` method to output the modified TAR file.