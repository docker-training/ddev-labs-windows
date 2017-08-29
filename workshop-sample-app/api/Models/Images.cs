using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Models
{
    public static class Images{
        private static List<Image> _images = new List<Image>{
          new Image{Id=1, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr05/15/9/anigif_enhanced-buzz-26388-1381844103-11.gif"},
          new Image{Id=2, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr01/15/9/anigif_enhanced-buzz-31540-1381844535-8.gif"},
          new Image{Id=3, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr05/15/9/anigif_enhanced-buzz-26390-1381844163-18.gif"},
          new Image{Id=4, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr06/15/10/anigif_enhanced-buzz-1376-1381846217-0.gif"},
          new Image{Id=5, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr03/15/9/anigif_enhanced-buzz-3391-1381844336-26.gif"},
          new Image{Id=6, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr06/15/10/anigif_enhanced-buzz-29111-1381845968-0.gif"},
          new Image{Id=7, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr03/15/9/anigif_enhanced-buzz-3409-1381844582-13.gif"},
          new Image{Id=8, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr02/15/9/anigif_enhanced-buzz-19667-1381844937-10.gif"},
          new Image{Id=9, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr05/15/9/anigif_enhanced-buzz-26358-1381845043-13.gif"},
          new Image{Id=10, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr06/15/9/anigif_enhanced-buzz-18774-1381844645-6.gif"},
          new Image{Id=11, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr06/15/9/anigif_enhanced-buzz-25158-1381844793-0.gif"},
          new Image{Id=12, Url="http://ak-hdl.buzzfed.com/static/2013-10/enhanced/webdr03/15/10/anigif_enhanced-buzz-11980-1381846269-1.gif"},
        };

        public static int Count{get{return _images.Count;}}

        public static List<Image> All(){
            return _images;
        }
        public static Image Get(int id){
            return _images.Single(x => x.Id == id);
        }
    }
}
