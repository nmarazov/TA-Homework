namespace Model.DefiningClasses.Models.Contracts
{
    public interface IOwner
    {
        string Name { get; }

        uint Age { get; }

        void MakeCall(IGsm gsm);
    }
}
