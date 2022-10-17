namespace Composite
{
    //Component
    public abstract class FileSystemItem
    {
        public string Name { get; set; }
        public abstract long GetSize();

        public FileSystemItem(string name)
        {
            Name = name;    
        }
    }

    //Leaf
    public class File : FileSystemItem
    {
        private long _size;
        public File(string name, long size) : base(name)
        {
            _size = size;   
        }

        public override long GetSize()
        {
            return _size;
        }
    }

    //Composite
    public class Directory : FileSystemItem
    {
        private long _size;
        private List<FileSystemItem> _fileSystemItems  = new List<FileSystemItem>();

        public Directory(string name, long size) : base(name)
        {
            _size = size; 
        }

        public void Add(FileSystemItem fileSystemItem)
        {
            _fileSystemItems.Add(fileSystemItem);
        }

        public void Remove(FileSystemItem fileSystemItem)
        {
            _fileSystemItems.Remove(fileSystemItem);    
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var item in _fileSystemItems)
            {
                treeSize += item.GetSize();
            }
            return treeSize;
        }
    }
}