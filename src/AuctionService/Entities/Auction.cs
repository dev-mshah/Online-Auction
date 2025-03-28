using AuctionService.Entities;

namespace AuctionService;

public class Auction
{
    public Guid Id {get; set;}
    
    public int Reserve {get; set;} = 0;

    public string Seller {get; set;}

    public string Winner {get; set;}

    public int? SoldAmount {get; set;}

    public int? CurrentHighBid {get; set;}
    
    public DateTime CreatedAt {get; set;} = DateTime.UtcNow;
    public DateTime UpdatedAt {get; set;} = DateTime.UtcNow;

    public Status Status {get; set;}

    public Item Item {get; set;}
    

}