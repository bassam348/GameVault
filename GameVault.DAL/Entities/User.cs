
namespace GameVault.DAL.Entities
{
    public class User
    {
        public int User_ID {get; private set;}
         public DateTime? CreatedOn { get; private set; }
         public bool IsDeleted { get; private set; }
         public DateTime? ModifiedOn { get; private set; }
         public string CreatedBy { get; private set; }

        public List<Game>? Games {get; set;} = new List<Game>();
    }
}
