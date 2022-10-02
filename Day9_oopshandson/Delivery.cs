using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Delivery
{
    private long _over;
    private long _ball;
    private long _runs;
    private string _batsman;
    private string _bowler;
    private string _nonStriker;

    public Delivery()
    {
    }

    public Delivery(long _over, long _ball, long _runs, string _batsman, string _bowler, string _nonStriker)
    {
        this._over = _over;
        this._ball = _ball;
        this._runs = _runs;
        this._batsman = _batsman;
        this._bowler = _bowler;
        this._nonStriker = _nonStriker;
    }
    
        public long over { get; set; }
        public long ball { get; set; }
        public long runs { get; set; }
        public string batsman { get; set; }
        public string bowler { get; set; }
        public string nonStriker { get; set; }

        
}



