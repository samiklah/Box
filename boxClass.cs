using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Box box1 = new Box(6,4,4,2);
            Box box2 = new Box(5,3,5,3);
            Box box3 = new Box(2,3,2,5);
            

            //print all boxs info
            //box1.boxInfo()

            //print this
            // box1.isOverWeight(3)

        }
    }

    class Box
    {
        private int length;
        private int width;
        private int height;
        private int weight;
        static int boxNumber;

        static int count;

        public Box(int length,int width,int height,int weight){
            this.length = length;
            this.width = width;
            this.height = height;
            this.weight = weight;
            this.count = this.count+1;
            this.boxNumber = this.boxNumber+1;
        }

        public int getCount(){
            return this.count;
        }
        public int getBoxNumber(){
            return this.boxNumber;
        }

        public int findVolume(){
            return this.length*this.width*this.height;
        }
        public int findSurfaceArea(){
            return surfaceArea(this.length,this.width);
        }
        public int findFootprint(){
            return this.length*this.width;
        }
        
        public bool isOverWeight(int limit){
            if(this.weight > limit){
                return true;
            }else{
                return false;
            }
        }

        private int surfaceArea(int dimen1,int dimen2){
            return dimen1*dimen2;
        }

        public string boxInfo(){
            string length = this.length.ToString();
            string width = this.width.ToString();
            string height = this.height.ToString();
            string weight = this.weight.ToString();

            string str = "box info:"+length+width+height+weight;

            return str;
        }


}
