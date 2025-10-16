using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EV_RENTAL_SYSTEM.Migrations
{
    /// <inheritdoc />
    public partial class FixConstraintNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Order_order_id",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_User_user_id",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Order_order_id",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractProcessing_Contract_contract_id",
                table: "ContractProcessing");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractProcessing_ProcessStep_step_id",
                table: "ContractProcessing");

            migrationBuilder.DropForeignKey(
                name: "FK_License_LicenseType_LicenseTypeId",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_user_id",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_LicensePlate_Station_station_id",
                table: "LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_LicensePlate_Vehicle_vehicle_id",
                table: "LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_LicensePlate_license_plate_id",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_user_id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_LicensePlate_LicensePlate_license_plate_id",
                table: "Order_LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_LicensePlate_Order_order_id",
                table: "Order_LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Contract_contract_id",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Payment_payment_id",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_user_id",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_role_id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Station_station_id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Brand_brand_id",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "vehicle_image",
                table: "Vehicle",
                newName: "Vehicle_image");

            migrationBuilder.RenameColumn(
                name: "seat_number",
                table: "Vehicle",
                newName: "Seat_number");

            migrationBuilder.RenameColumn(
                name: "range_km",
                table: "Vehicle",
                newName: "Range_km");

            migrationBuilder.RenameColumn(
                name: "price_per_day",
                table: "Vehicle",
                newName: "Price_per_day");

            migrationBuilder.RenameColumn(
                name: "model_year",
                table: "Vehicle",
                newName: "Model_year");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Vehicle",
                newName: "Brand_Id");

            migrationBuilder.RenameColumn(
                name: "battery",
                table: "Vehicle",
                newName: "Battery");

            migrationBuilder.RenameColumn(
                name: "vehicle_id",
                table: "Vehicle",
                newName: "Vehicle_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_brand_id",
                table: "Vehicle",
                newName: "IX_Vehicle_Brand_Id");

            migrationBuilder.RenameColumn(
                name: "station_id",
                table: "User",
                newName: "Station_Id");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "User",
                newName: "Role_Id");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "User",
                newName: "Phone_number");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "User",
                newName: "Full_name");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "User",
                newName: "Created_at");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "User",
                newName: "User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_station_id",
                table: "User",
                newName: "IX_User_Station_Id");

            migrationBuilder.RenameIndex(
                name: "IX_User_role_id",
                table: "User",
                newName: "IX_User_Role_Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Transaction",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "transaction_date",
                table: "Transaction",
                newName: "Transaction_date");

            migrationBuilder.RenameColumn(
                name: "payment_id",
                table: "Transaction",
                newName: "Payment_Id");

            migrationBuilder.RenameColumn(
                name: "transaction_id",
                table: "Transaction",
                newName: "Transaction_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_user_id",
                table: "Transaction",
                newName: "IX_Transaction_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_payment_id",
                table: "Transaction",
                newName: "IX_Transaction_Payment_Id");

            migrationBuilder.RenameColumn(
                name: "total_vehicle",
                table: "Station",
                newName: "Total_Vehicle");

            migrationBuilder.RenameColumn(
                name: "station_name",
                table: "Station",
                newName: "Station_name");

            migrationBuilder.RenameColumn(
                name: "available_vehicle",
                table: "Station",
                newName: "Available_Vehicle");

            migrationBuilder.RenameColumn(
                name: "station_id",
                table: "Station",
                newName: "Station_Id");

            migrationBuilder.RenameColumn(
                name: "role_name",
                table: "Role",
                newName: "Role_name");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "Role",
                newName: "Role_Id");

            migrationBuilder.RenameColumn(
                name: "step_name",
                table: "ProcessStep",
                newName: "Step_name");

            migrationBuilder.RenameColumn(
                name: "step_id",
                table: "ProcessStep",
                newName: "Step_Id");

            migrationBuilder.RenameColumn(
                name: "payment_date",
                table: "Payment",
                newName: "Payment_date");

            migrationBuilder.RenameColumn(
                name: "contract_id",
                table: "Payment",
                newName: "Contract_Id");

            migrationBuilder.RenameColumn(
                name: "payment_id",
                table: "Payment",
                newName: "Payment_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_contract_id",
                table: "Payment",
                newName: "IX_Payment_Contract_Id");

            migrationBuilder.RenameColumn(
                name: "license_plate_id",
                table: "Order_LicensePlate",
                newName: "License_plate_Id");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Order_LicensePlate",
                newName: "Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_LicensePlate_license_plate_id",
                table: "Order_LicensePlate",
                newName: "IX_Order_LicensePlate_License_plate_Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Order",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "total_amount",
                table: "Order",
                newName: "Total_amount");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Order",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "Order",
                newName: "Start_time");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Order",
                newName: "Order_date");

            migrationBuilder.RenameColumn(
                name: "end_time",
                table: "Order",
                newName: "End_time");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Order",
                newName: "Order_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_user_id",
                table: "Order",
                newName: "IX_Order_User_Id");

            migrationBuilder.RenameColumn(
                name: "maintenance_date",
                table: "Maintenance",
                newName: "Maintenance_date");

            migrationBuilder.RenameColumn(
                name: "license_plate_id",
                table: "Maintenance",
                newName: "License_plate_Id");

            migrationBuilder.RenameColumn(
                name: "maintenance_id",
                table: "Maintenance",
                newName: "Maintenance_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Maintenance_license_plate_id",
                table: "Maintenance",
                newName: "IX_Maintenance_License_plate_Id");

            migrationBuilder.RenameColumn(
                name: "type_name",
                table: "LicenseType",
                newName: "Type_name");

            migrationBuilder.RenameColumn(
                name: "license_type_id",
                table: "LicenseType",
                newName: "License_type_Id");

            migrationBuilder.RenameColumn(
                name: "vehicle_id",
                table: "LicensePlate",
                newName: "Vehicle_Id");

            migrationBuilder.RenameColumn(
                name: "station_id",
                table: "LicensePlate",
                newName: "Station_Id");

            migrationBuilder.RenameColumn(
                name: "registration_date",
                table: "LicensePlate",
                newName: "Registration_date");

            migrationBuilder.RenameColumn(
                name: "plate_number",
                table: "LicensePlate",
                newName: "Plate_Number");

            migrationBuilder.RenameColumn(
                name: "license_plate_id",
                table: "LicensePlate",
                newName: "License_plate_Id");

            migrationBuilder.RenameIndex(
                name: "IX_LicensePlate_vehicle_id",
                table: "LicensePlate",
                newName: "IX_LicensePlate_Vehicle_Id");

            migrationBuilder.RenameIndex(
                name: "IX_LicensePlate_station_id",
                table: "LicensePlate",
                newName: "IX_LicensePlate_Station_Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "License",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "license_type_id",
                table: "License",
                newName: "License_type_Id");

            migrationBuilder.RenameColumn(
                name: "license_number",
                table: "License",
                newName: "License_number");

            migrationBuilder.RenameColumn(
                name: "expiry_date",
                table: "License",
                newName: "Expiry_date");

            migrationBuilder.RenameColumn(
                name: "license_id",
                table: "License",
                newName: "License_Id");

            migrationBuilder.RenameColumn(
                name: "license_image_url",
                table: "License",
                newName: "License_ImageUrl");

            migrationBuilder.RenameIndex(
                name: "IX_License_user_id",
                table: "License",
                newName: "IX_License_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_License_license_type_id",
                table: "License",
                newName: "IX_License_License_type_Id");

            migrationBuilder.RenameIndex(
                name: "IX_License_license_number",
                table: "License",
                newName: "IX_License_License_number");

            migrationBuilder.RenameColumn(
                name: "step_id",
                table: "ContractProcessing",
                newName: "Step_Id");

            migrationBuilder.RenameColumn(
                name: "contract_id",
                table: "ContractProcessing",
                newName: "Contract_Id");

            migrationBuilder.RenameColumn(
                name: "contract_processing_id",
                table: "ContractProcessing",
                newName: "ContractProcessing_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ContractProcessing_step_id",
                table: "ContractProcessing",
                newName: "IX_ContractProcessing_Step_Id");

            migrationBuilder.RenameIndex(
                name: "IX_ContractProcessing_contract_id",
                table: "ContractProcessing",
                newName: "IX_ContractProcessing_Contract_Id");

            migrationBuilder.RenameColumn(
                name: "rental_fee",
                table: "Contract",
                newName: "Rental_fee");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Contract",
                newName: "Order_Id");

            migrationBuilder.RenameColumn(
                name: "extra_fee",
                table: "Contract",
                newName: "Extra_fee");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "Contract",
                newName: "Created_date");

            migrationBuilder.RenameColumn(
                name: "contract_code",
                table: "Contract",
                newName: "Contract_Code");

            migrationBuilder.RenameColumn(
                name: "contract_id",
                table: "Contract",
                newName: "Contract_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_order_id",
                table: "Contract",
                newName: "IX_Contract_Order_Id");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Complaint",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Complaint",
                newName: "Order_Id");

            migrationBuilder.RenameColumn(
                name: "complaint_date",
                table: "Complaint",
                newName: "Complaint_date");

            migrationBuilder.RenameColumn(
                name: "complaint_id",
                table: "Complaint",
                newName: "Complaint_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_user_id",
                table: "Complaint",
                newName: "IX_Complaint_User_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_order_id",
                table: "Complaint",
                newName: "IX_Complaint_Order_Id");

            migrationBuilder.RenameColumn(
                name: "brand_name",
                table: "Brand",
                newName: "Brand_name");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "Brand",
                newName: "Brand_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Order_Order_Id",
                table: "Complaint",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_User_User_Id",
                table: "Complaint",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Order_Order_Id",
                table: "Contract",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractProcessing_Contract_Contract_Id",
                table: "ContractProcessing",
                column: "Contract_Id",
                principalTable: "Contract",
                principalColumn: "Contract_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractProcessing_ProcessStep_Step_Id",
                table: "ContractProcessing",
                column: "Step_Id",
                principalTable: "ProcessStep",
                principalColumn: "Step_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_LicenseType_License_type_Id",
                table: "License",
                column: "License_type_Id",
                principalTable: "LicenseType",
                principalColumn: "License_type_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_User_User_Id",
                table: "License",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LicensePlate_Station_Station_Id",
                table: "LicensePlate",
                column: "Station_Id",
                principalTable: "Station",
                principalColumn: "Station_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LicensePlate_Vehicle_Vehicle_Id",
                table: "LicensePlate",
                column: "Vehicle_Id",
                principalTable: "Vehicle",
                principalColumn: "Vehicle_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_LicensePlate_License_plate_Id",
                table: "Maintenance",
                column: "License_plate_Id",
                principalTable: "LicensePlate",
                principalColumn: "License_plate_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_User_Id",
                table: "Order",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_LicensePlate_LicensePlate_License_plate_Id",
                table: "Order_LicensePlate",
                column: "License_plate_Id",
                principalTable: "LicensePlate",
                principalColumn: "License_plate_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_LicensePlate_Order_Order_Id",
                table: "Order_LicensePlate",
                column: "Order_Id",
                principalTable: "Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Contract_Contract_Id",
                table: "Payment",
                column: "Contract_Id",
                principalTable: "Contract",
                principalColumn: "Contract_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Payment_Payment_Id",
                table: "Transaction",
                column: "Payment_Id",
                principalTable: "Payment",
                principalColumn: "Payment_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_User_User_Id",
                table: "Transaction",
                column: "User_Id",
                principalTable: "User",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_Role_Id",
                table: "User",
                column: "Role_Id",
                principalTable: "Role",
                principalColumn: "Role_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Station_Station_Id",
                table: "User",
                column: "Station_Id",
                principalTable: "Station",
                principalColumn: "Station_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Brand_Brand_Id",
                table: "Vehicle",
                column: "Brand_Id",
                principalTable: "Brand",
                principalColumn: "Brand_Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_Order_Order_Id",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Complaint_User_User_Id",
                table: "Complaint");

            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Order_Order_Id",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractProcessing_Contract_Contract_Id",
                table: "ContractProcessing");

            migrationBuilder.DropForeignKey(
                name: "FK_ContractProcessing_ProcessStep_Step_Id",
                table: "ContractProcessing");

            migrationBuilder.DropForeignKey(
                name: "FK_License_LicenseType_License_type_Id",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_License_User_User_Id",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_LicensePlate_Station_Station_Id",
                table: "LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_LicensePlate_Vehicle_Vehicle_Id",
                table: "LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenance_LicensePlate_License_plate_Id",
                table: "Maintenance");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_User_Id",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_LicensePlate_LicensePlate_License_plate_Id",
                table: "Order_LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_LicensePlate_Order_Order_Id",
                table: "Order_LicensePlate");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Contract_Contract_Id",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Payment_Payment_Id",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_User_Id",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_Role_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Station_Station_Id",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Brand_Brand_Id",
                table: "Vehicle");

            migrationBuilder.RenameColumn(
                name: "Vehicle_image",
                table: "Vehicle",
                newName: "vehicle_image");

            migrationBuilder.RenameColumn(
                name: "Seat_number",
                table: "Vehicle",
                newName: "seat_number");

            migrationBuilder.RenameColumn(
                name: "Range_km",
                table: "Vehicle",
                newName: "range_km");

            migrationBuilder.RenameColumn(
                name: "Price_per_day",
                table: "Vehicle",
                newName: "price_per_day");

            migrationBuilder.RenameColumn(
                name: "Model_year",
                table: "Vehicle",
                newName: "model_year");

            migrationBuilder.RenameColumn(
                name: "Brand_Id",
                table: "Vehicle",
                newName: "brand_id");

            migrationBuilder.RenameColumn(
                name: "Battery",
                table: "Vehicle",
                newName: "battery");

            migrationBuilder.RenameColumn(
                name: "Vehicle_Id",
                table: "Vehicle",
                newName: "vehicle_id");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_Brand_Id",
                table: "Vehicle",
                newName: "IX_Vehicle_brand_id");

            migrationBuilder.RenameColumn(
                name: "Station_Id",
                table: "User",
                newName: "station_id");

            migrationBuilder.RenameColumn(
                name: "Role_Id",
                table: "User",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "Phone_number",
                table: "User",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "Full_name",
                table: "User",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "User",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "User",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Station_Id",
                table: "User",
                newName: "IX_User_station_id");

            migrationBuilder.RenameIndex(
                name: "IX_User_Role_Id",
                table: "User",
                newName: "IX_User_role_id");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Transaction",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Transaction_date",
                table: "Transaction",
                newName: "transaction_date");

            migrationBuilder.RenameColumn(
                name: "Payment_Id",
                table: "Transaction",
                newName: "payment_id");

            migrationBuilder.RenameColumn(
                name: "Transaction_Id",
                table: "Transaction",
                newName: "transaction_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_User_Id",
                table: "Transaction",
                newName: "IX_Transaction_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_Payment_Id",
                table: "Transaction",
                newName: "IX_Transaction_payment_id");

            migrationBuilder.RenameColumn(
                name: "Total_Vehicle",
                table: "Station",
                newName: "total_vehicle");

            migrationBuilder.RenameColumn(
                name: "Station_name",
                table: "Station",
                newName: "station_name");

            migrationBuilder.RenameColumn(
                name: "Available_Vehicle",
                table: "Station",
                newName: "available_vehicle");

            migrationBuilder.RenameColumn(
                name: "Station_Id",
                table: "Station",
                newName: "station_id");

            migrationBuilder.RenameColumn(
                name: "Role_name",
                table: "Role",
                newName: "role_name");

            migrationBuilder.RenameColumn(
                name: "Role_Id",
                table: "Role",
                newName: "role_id");

            migrationBuilder.RenameColumn(
                name: "Step_name",
                table: "ProcessStep",
                newName: "step_name");

            migrationBuilder.RenameColumn(
                name: "Step_Id",
                table: "ProcessStep",
                newName: "step_id");

            migrationBuilder.RenameColumn(
                name: "Payment_date",
                table: "Payment",
                newName: "payment_date");

            migrationBuilder.RenameColumn(
                name: "Contract_Id",
                table: "Payment",
                newName: "contract_id");

            migrationBuilder.RenameColumn(
                name: "Payment_Id",
                table: "Payment",
                newName: "payment_id");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_Contract_Id",
                table: "Payment",
                newName: "IX_Payment_contract_id");

            migrationBuilder.RenameColumn(
                name: "License_plate_Id",
                table: "Order_LicensePlate",
                newName: "license_plate_id");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Order_LicensePlate",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_LicensePlate_License_plate_Id",
                table: "Order_LicensePlate",
                newName: "IX_Order_LicensePlate_license_plate_id");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Order",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Total_amount",
                table: "Order",
                newName: "total_amount");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Order",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Start_time",
                table: "Order",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "Order_date",
                table: "Order",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "End_time",
                table: "Order",
                newName: "end_time");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Order",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Order_User_Id",
                table: "Order",
                newName: "IX_Order_user_id");

            migrationBuilder.RenameColumn(
                name: "Maintenance_date",
                table: "Maintenance",
                newName: "maintenance_date");

            migrationBuilder.RenameColumn(
                name: "License_plate_Id",
                table: "Maintenance",
                newName: "license_plate_id");

            migrationBuilder.RenameColumn(
                name: "Maintenance_Id",
                table: "Maintenance",
                newName: "maintenance_id");

            migrationBuilder.RenameIndex(
                name: "IX_Maintenance_License_plate_Id",
                table: "Maintenance",
                newName: "IX_Maintenance_license_plate_id");

            migrationBuilder.RenameColumn(
                name: "Type_name",
                table: "LicenseType",
                newName: "type_name");

            migrationBuilder.RenameColumn(
                name: "License_type_Id",
                table: "LicenseType",
                newName: "license_type_id");

            migrationBuilder.RenameColumn(
                name: "Vehicle_Id",
                table: "LicensePlate",
                newName: "vehicle_id");

            migrationBuilder.RenameColumn(
                name: "Station_Id",
                table: "LicensePlate",
                newName: "station_id");

            migrationBuilder.RenameColumn(
                name: "Registration_date",
                table: "LicensePlate",
                newName: "registration_date");

            migrationBuilder.RenameColumn(
                name: "Plate_Number",
                table: "LicensePlate",
                newName: "plate_number");

            migrationBuilder.RenameColumn(
                name: "License_plate_Id",
                table: "LicensePlate",
                newName: "license_plate_id");

            migrationBuilder.RenameIndex(
                name: "IX_LicensePlate_Vehicle_Id",
                table: "LicensePlate",
                newName: "IX_LicensePlate_vehicle_id");

            migrationBuilder.RenameIndex(
                name: "IX_LicensePlate_Station_Id",
                table: "LicensePlate",
                newName: "IX_LicensePlate_station_id");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "License",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "License_type_Id",
                table: "License",
                newName: "license_type_id");

            migrationBuilder.RenameColumn(
                name: "License_number",
                table: "License",
                newName: "license_number");

            migrationBuilder.RenameColumn(
                name: "Expiry_date",
                table: "License",
                newName: "expiry_date");

            migrationBuilder.RenameColumn(
                name: "License_Id",
                table: "License",
                newName: "license_id");

            migrationBuilder.RenameColumn(
                name: "License_ImageUrl",
                table: "License",
                newName: "license_image_url");

            migrationBuilder.RenameIndex(
                name: "IX_License_User_Id",
                table: "License",
                newName: "IX_License_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_License_License_type_Id",
                table: "License",
                newName: "IX_License_license_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_License_License_number",
                table: "License",
                newName: "IX_License_license_number");

            migrationBuilder.RenameColumn(
                name: "Step_Id",
                table: "ContractProcessing",
                newName: "step_id");

            migrationBuilder.RenameColumn(
                name: "Contract_Id",
                table: "ContractProcessing",
                newName: "contract_id");

            migrationBuilder.RenameColumn(
                name: "ContractProcessing_Id",
                table: "ContractProcessing",
                newName: "contract_processing_id");

            migrationBuilder.RenameIndex(
                name: "IX_ContractProcessing_Step_Id",
                table: "ContractProcessing",
                newName: "IX_ContractProcessing_step_id");

            migrationBuilder.RenameIndex(
                name: "IX_ContractProcessing_Contract_Id",
                table: "ContractProcessing",
                newName: "IX_ContractProcessing_contract_id");

            migrationBuilder.RenameColumn(
                name: "Rental_fee",
                table: "Contract",
                newName: "rental_fee");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Contract",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "Extra_fee",
                table: "Contract",
                newName: "extra_fee");

            migrationBuilder.RenameColumn(
                name: "Created_date",
                table: "Contract",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "Contract_Code",
                table: "Contract",
                newName: "contract_code");

            migrationBuilder.RenameColumn(
                name: "Contract_Id",
                table: "Contract",
                newName: "contract_id");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_Order_Id",
                table: "Contract",
                newName: "IX_Contract_order_id");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Complaint",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "Order_Id",
                table: "Complaint",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "Complaint_date",
                table: "Complaint",
                newName: "complaint_date");

            migrationBuilder.RenameColumn(
                name: "Complaint_Id",
                table: "Complaint",
                newName: "complaint_id");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_User_Id",
                table: "Complaint",
                newName: "IX_Complaint_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Complaint_Order_Id",
                table: "Complaint",
                newName: "IX_Complaint_order_id");

            migrationBuilder.RenameColumn(
                name: "Brand_name",
                table: "Brand",
                newName: "brand_name");

            migrationBuilder.RenameColumn(
                name: "Brand_Id",
                table: "Brand",
                newName: "brand_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_Order_order_id",
                table: "Complaint",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Complaint_User_user_id",
                table: "Complaint",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Order_order_id",
                table: "Contract",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractProcessing_Contract_contract_id",
                table: "ContractProcessing",
                column: "contract_id",
                principalTable: "Contract",
                principalColumn: "contract_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContractProcessing_ProcessStep_step_id",
                table: "ContractProcessing",
                column: "step_id",
                principalTable: "ProcessStep",
                principalColumn: "step_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_LicenseType_license_type_id",
                table: "License",
                column: "license_type_id",
                principalTable: "LicenseType",
                principalColumn: "license_type_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_User_user_id",
                table: "License",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LicensePlate_Station_station_id",
                table: "LicensePlate",
                column: "station_id",
                principalTable: "Station",
                principalColumn: "station_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LicensePlate_Vehicle_vehicle_id",
                table: "LicensePlate",
                column: "vehicle_id",
                principalTable: "Vehicle",
                principalColumn: "vehicle_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenance_LicensePlate_license_plate_id",
                table: "Maintenance",
                column: "license_plate_id",
                principalTable: "LicensePlate",
                principalColumn: "license_plate_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_user_id",
                table: "Order",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_LicensePlate_LicensePlate_license_plate_id",
                table: "Order_LicensePlate",
                column: "license_plate_id",
                principalTable: "LicensePlate",
                principalColumn: "license_plate_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_LicensePlate_Order_order_id",
                table: "Order_LicensePlate",
                column: "order_id",
                principalTable: "Order",
                principalColumn: "order_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Contract_contract_id",
                table: "Payment",
                column: "contract_id",
                principalTable: "Contract",
                principalColumn: "contract_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Payment_payment_id",
                table: "Transaction",
                column: "payment_id",
                principalTable: "Payment",
                principalColumn: "payment_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_User_user_id",
                table: "Transaction",
                column: "user_id",
                principalTable: "User",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_role_id",
                table: "User",
                column: "role_id",
                principalTable: "Role",
                principalColumn: "role_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Station_station_id",
                table: "User",
                column: "station_id",
                principalTable: "Station",
                principalColumn: "station_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Brand_brand_id",
                table: "Vehicle",
                column: "brand_id",
                principalTable: "Brand",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
