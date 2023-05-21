using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class Comment
{
    public int CommentId { get; set; }

    public string? Description { get; set; }

    public int? GuestId { get; set; }

    public int? StaffId { get; set; }

    public DateTime? CommentTime { get; set; }

    public int? HotelId { get; set; }

    public bool? IsDeleted { get; set; }

    public int? UserReview { get; set; }

    public int? ParentKey { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual ICollection<Comment> InverseParentKeyNavigation { get; set; } = new List<Comment>();

    public virtual Comment? ParentKeyNavigation { get; set; }

    public virtual Rating? UserReviewNavigation { get; set; }
}
