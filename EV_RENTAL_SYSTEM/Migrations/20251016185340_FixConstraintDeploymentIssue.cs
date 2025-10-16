using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EV_RENTAL_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class FixConstraintDeploymentIssue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // This migration handles the constraint issue when deploying to Render
            // The issue is that the constraint FK_Contract_Order_OrderId might not exist
            // when the AddContractCodeToContract migration tries to drop it
            
            // Only for PostgreSQL (since the app uses UseNpgsql)
            migrationBuilder.Sql(@"
                DO $$ 
                BEGIN
                    IF EXISTS (SELECT 1 FROM information_schema.table_constraints 
                              WHERE constraint_name = 'FK_Contract_Order_OrderId' 
                              AND table_name = 'Contract') THEN
                        ALTER TABLE ""Contract"" DROP CONSTRAINT ""FK_Contract_Order_OrderId"";
                    END IF;
                END $$;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // This migration is safe to rollback as it only drops constraints conditionally
            // No action needed in Down method
        }
    }
}
