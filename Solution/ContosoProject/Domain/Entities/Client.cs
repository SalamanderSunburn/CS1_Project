using System.Collections.Generic;
using Domain.Entities.Comments;

namespace Domain.Entities
{
    public class Client : ExtendedEntity, ICommentable
    {
        public Location ClientLocation { get; set; }
        public Person Person { get; set; }
        private ICollection<string> _telephones;
<<<<<<< HEAD
        private ICollection<Comment> _comments;
        public Client(ICollection<string> telephones, ICollection<Comment> comments)
=======

        public Client(ICollection<string> telephones)
>>>>>>> parent of 3a07962... Revert "ClientForm design and 75% impl."
        {
            _telephones = telephones;
            _comments = comments;
        }
        public IReadOnlyCollection<string> Telephones
        {
            get
            {
                return (IReadOnlyCollection<string>)_telephones;
            }
        }

<<<<<<< HEAD
        public IReadOnlyCollection<Comment> Comments
        {
            get { return (IReadOnlyCollection<Comment>)_comments; }
        }
=======
>>>>>>> parent of 3a07962... Revert "ClientForm design and 75% impl."
    }
}
