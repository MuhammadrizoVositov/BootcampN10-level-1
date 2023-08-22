using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N28_HT2
{
    internal class StorageFile:ICloneable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }

        public StorageFile(string name,string description,int size)
        {
            Name = name;
            Description = description;
            Size = size;
        }

        public object Clone()
        {
            return new StorageFile(this.Name, this.Description, this.Size);
        }
        public override string ToString()
        {
            return $"{Name}  {Description}  {Size}";
        }
    }
}
