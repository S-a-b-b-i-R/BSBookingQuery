using System;
using System.Collections.Generic;

namespace BSBookingQuery.DAL.Entities;

public partial class CommentDetail
{
    public int CommentDetailId { get; set; }

    public int? CommentId { get; set; }

    public int? GuestId { get; set; }

    public int? StaffId { get; set; }

    public DateTime? CommentTime { get; set; }

    public bool? IsDeleted { get; set; }

    public string? Description { get; set; }

    public virtual Comment? Comment { get; set; }

    public virtual Guest? Guest { get; set; }

    public virtual Staff? Staff { get; set; }
}
