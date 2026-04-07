using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParcelService.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parcel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Destination_Region = table.Column<string>(type: "text", nullable: false),
                    Destination_Terminal = table.Column<string>(type: "text", nullable: false),
                    Receiver_Name = table.Column<string>(type: "text", nullable: false),
                    Receiver_Address_City = table.Column<string>(type: "text", nullable: false),
                    Receiver_Address_Country = table.Column<string>(type: "text", nullable: false),
                    Receiver_Address_HouseNumber = table.Column<string>(type: "text", nullable: false),
                    Receiver_Address_Street = table.Column<string>(type: "text", nullable: false),
                    Receiver_Address_ZipCode = table.Column<string>(type: "text", nullable: false),
                    Sender_Name = table.Column<string>(type: "text", nullable: false),
                    Sender_Address_City = table.Column<string>(type: "text", nullable: false),
                    Sender_Address_Country = table.Column<string>(type: "text", nullable: false),
                    Sender_Address_HouseNumber = table.Column<string>(type: "text", nullable: false),
                    Sender_Address_Street = table.Column<string>(type: "text", nullable: false),
                    Sender_Address_ZipCode = table.Column<string>(type: "text", nullable: false),
                    Tracking_Status = table.Column<string>(type: "text", nullable: false),
                    Tracking_TrackingNumber = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parcel", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parcel");
        }
    }
}
