using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordMatchMaking
{
    public class Player
    {

        #region Data Members
        private List<UserName> _userNames = new();
        public IReadOnlyList<UserName> UserNames => _userNames.AsReadOnly();
        private Regions _region;
        private int _wins;
        private int _losses;
        private int _rankingScore;
        private DateOnly _creationDate;
        private bool _isAdmin = false;
        #endregion

        #region Properties
        public Regions Region
        {
            get
            {
                return _region;
            }
            private set
            {
                if(!Enum.IsDefined(typeof(Regions), value))
                {
                    throw new ArgumentException("Invalid Region");
                }

                _region = value;
            }
        }

        public int Wins
        {
            get
            {
                return _wins;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A player cannot have wins less than 0");
                }
                _wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return _losses;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A player cannot have losses less than 0");
                }
                _losses = value;
            }
        }

        public int RankingScore
        {
            get
            {
                return _rankingScore;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A player cannot have a negative ranking score");
                }
            }
        }
        
        public DateOnly CreationDate
        {
            get
            {
                return _creationDate;
            }
            private set
            {
                var today = DateOnly.FromDateTime(DateTime.Now);

                if (value != today)
                {
                    throw new ArgumentException("A Players creation date cannot be in the past or future from actual creation");
                }
            }

        }

        
        #endregion
    }
}
