using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.BLL.Entities
{
    public class UserProfile
    {
        #region Propriétés

        public Guid UserProfileId { get; private set; }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
                if (value.Length > 32) throw new FormatException();
                _lastName = value;
            }
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
                if (value.Length > 32) throw new FormatException();
                _firstName = value;
            }
        }

        public DateTime BirthDate { get; private set; }
        public ushort YearsOld
        {
            get
            {
                ushort years = (ushort)(DateTime.Now.Year- BirthDate.Year);
                if (BirthDate > DateTime.Now.AddYears(-years)){
                    years--;
                }
                return years;
            }
        }

        private string? _biography;
        public string? Biography
        {
            get
            {
                return _biography;
            }
            set
            {
                if (value is null)
                {
                    _biography = value;
                    return;
                }
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException(nameof(value));
                if (value.Length > 512) throw new FormatException();
                _biography = value;
            }
        }

        private ushort? _readingSkill;
        public ushort? ReadingSkill
        {
            get
            { return _readingSkill; }

            set
            {
                if (!(value is null) && (value < 1 || value > 6)) throw new ArgumentOutOfRangeException(nameof(value));

                _readingSkill = value;
            }
        }
        public bool NewsLetterSubscribed { get; set; }
        public uint RegisterDaysCounter
        {
            get
            {
                return (uint)(DateTime.Now - RegisteredDate).TotalDays;
            }
        }
        public DateTime RegisteredDate { get; private set; }
        public DateTime? DisabledDate { get; private set; }
        #endregion

        #region Constructeurs
        public UserProfile(string lastName, string firstName, DateTime birthDate, bool newsLetterSubscribed = true)
        {
            //NE PAS OUBLIER DE CREER L'ID
            UserProfileId = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            NewsLetterSubscribed = newsLetterSubscribed;
            RegisteredDate = DateTime.Now;

        }


        public UserProfile(Guid userProfileId, string lastName, string firstName, DateTime birthDate, string? biography, bool newsLetterSubscribed, DateTime registeredDate, DateTime? disabledDate, byte? readingSkill)
        {
            //Ici l'ID est récupéré dans les paramètres du constructeur. Notamment pour quand on passe par le mapper,
            //Pour pouvoir prendre l'ID du DAL et le mettre dans le BLL par exemple
            UserProfileId = userProfileId;
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            NewsLetterSubscribed = newsLetterSubscribed;
            RegisteredDate = DateTime.Now;
            Biography = biography;
            DisabledDate = disabledDate;
            RegisteredDate = registeredDate;
            ReadingSkill = readingSkill;

        }
        #endregion

        public void Disable()
        {
            DisabledDate = DateTime.Now;
        }


    }
}
