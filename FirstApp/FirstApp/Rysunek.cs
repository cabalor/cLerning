using System;
using System.Collections.Generic;

namespace FirstApp
{
    public class Rysunek
    {
        public void RysujKształt(List<Kształt> kształty)
        {
            foreach(var k in kształty)
            {
                k.Rysuj();
            }
        }
    }
}
