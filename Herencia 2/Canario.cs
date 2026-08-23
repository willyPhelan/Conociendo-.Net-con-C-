using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_2 {
    internal class Canario:AnimalDomestico, IComparable, Flyers{

    public int CompareTo(object obj){

        throw new NotImplementedException() ;

    }

    public string volar(){

        return "Vuelo de canario" ;  
    }


    
    }
}
