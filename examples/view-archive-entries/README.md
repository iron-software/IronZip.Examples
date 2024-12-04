***Based on <https://ironsoftware.com/examples/view-archive-entries/>***

Inspecting the contents of a file within a ZIP archive without extracting it is a straightforward process with IronZIP. This functionality enables developers to explore and preview the names of files contained within the archive directly.

To initiate this process, begin by opening the archive. This is done by providing the path to the archive file to the constructor. Afterwards, employ the `GetArchiveEntryNames` method to fetch a list of all entry names from the open archive.