namespace FriendLetter.Models
{
  public class LetterVariable
  {
    private string _recipient;

    public string GetRecipient()
    {
      return _recipient;
    }
    public void SetRecipient(string newRecipient)
    {
      _recipient = newRecipient;
    }

    private string _location;
    public string GetLocation()
    {
      return _location;
    }
    public void SetLocation(string newLocation)
    {
      _location = newLocation;
    }

    private string _items;
    public string GetItems()
    {
      return _items;
    }
    public void SetItems(string newItems)
    {
      _items = newItems;
    }

  }
}
