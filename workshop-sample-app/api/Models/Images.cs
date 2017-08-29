using System;
using api.Models;

namespace api.Models{
    public static class Images{
        private static List<Image> _images = new List<Image>{
            new Image{Id=1, Name="cat"},
            new Image{Id=2, Name="donkey"},
            new Image{Id=3, Name="wolf"},
        };

        public static int Count{get{return _images.Count;}}

        public List<Image> All(){
            return _images;
        }
        public static Image Get(int id){
            return _images.Single(x.Id == id);
        }
    }
}