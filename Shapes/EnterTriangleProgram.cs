using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public class EnterTriangleProgram : MenuProgram
    {
        private List<Triangle> listTriangles;
        public EnterTriangleProgram()
        {
            listTriangles = new List<Triangle>();
        }
        
        public List<Triangle> ListTriangles
        {
            get { return listTriangles; }
        }

        public override void PrintMenu()
        {
            // TODO: in menu cho lua chon nhap 3 loai tam giac (thuong, can, deu)
        }

        public override void DoTask(int choice)
        {
            // TODO: ung voi moi lua chon, y/c nguoi dung nhap loai tam giac tuong ung
            // add listTriangles
        }
    }
}