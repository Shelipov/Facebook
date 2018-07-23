using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Facebook.Data.Migrations
{
    public partial class Facebook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Facebookoptions",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    AppId = table.Column<string>(nullable: true),
                    AppSecret = table.Column<string>(nullable: true),
                    AuthorizationEndpoint = table.Column<string>(nullable: true),
                    BackchannelHttpHandler = table.Column<string>(nullable: true),
                    BackchannelTimeout = table.Column<TimeSpan>(nullable: false),
                    CallbackPath = table.Column<string>(nullable: true),
                    ClaimsIssuer = table.Column<string>(nullable: true),
                    ClientId = table.Column<string>(nullable: true),
                    ClientSecret = table.Column<string>(nullable: true),
                    Events = table.Column<string>(nullable: true),
                    RemoteAuthenticationTimeout = table.Column<TimeSpan>(nullable: false),
                    SendAppSecretProof = table.Column<bool>(nullable: false),
                    SignInScheme = table.Column<string>(nullable: true),
                    TokenEndpoint = table.Column<string>(nullable: true),
                    UserInformationEndpoint = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facebookoptions", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facebookoptions");
        }
    }
}
