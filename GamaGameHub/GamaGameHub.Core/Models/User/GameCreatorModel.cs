namespace GamaGameHub.Core.Models.User
{
    public class GameCreatorModel : UserModel
    {
        public int? YearOfCreating { get; set; }
        public string? AdditionalInformation { get; set; }
    }
}
