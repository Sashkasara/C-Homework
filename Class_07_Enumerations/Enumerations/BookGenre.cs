using System;
using System.Collections.Generic;
using System.Text;

namespace Enumerations
{
    public enum BookGenre
    {
        Adventure = 0, // Start with 1!
        Drama = 1, // ako ne mustavime broj sam si gi ispisuva i gi inkrementira po eden
        Horror = 2, // primer ako mu stavam 200, naredniot ke bide 201
        Thriller = 3,
        Sci_Fi,
        Biography,
        Comedy
    }

}
