***Based on <https://ironsoftware.com/examples/view-archive-entries/>***

Exploring the contents of a ZIP file without actually extracting it can be conveniently accomplished using IronZIP. This feature enables users to peek at the contents of the archive, revealing the names of the files contained within.

To initiate this process, you must first open the archive. This is achieved by supplying the path to the archive file to the constructor. Subsequently, the `GetArchiveEntryNames` method is utilized. Invoking this method will fetch a list of all entries within the archive that's currently open.