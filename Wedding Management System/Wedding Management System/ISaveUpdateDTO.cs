using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Management_System
{
    public interface ISaveUpdateDTO
    {
        public int Save(PostUserDTO post);
        public int Update(PutUserDTO put);
    }
}
