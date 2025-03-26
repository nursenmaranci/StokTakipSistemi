# Stok Takip Sistemi (Inventory Tracking System)

This C# Windows Forms application provides a system for managing and tracking inventory. It uses SQL Server as the backend database.

## Features

* **Product Management:** Add, edit, and delete product information.  (UrunEkleme.cs)
* **Customer Management:** Manage customer details. (MusteriEkleme.cs)
* **Supplier Management:** Manage supplier information. (TedarikciEkleme.cs)
* **Stock Movements:** Track stock in and out movements. (StokHareketleri.cs)
* **Reporting:** Generate reports on inventory levels, transactions, etc. (Raporlama.cs)

## Requirements

* **Software:**
    * Visual Studio (or .NET SDK)
    * SQL Server (or SQL Server Express)
* **.NET Framework or .NET**  


## Setup

1. **Database:** Create a SQL Server database and configure the connection string in the `app.config` or `Program.cs` file. Tables include: Products, Suppliers, Customers, StockMovements, Reports.
2. **Build:** Open the `StokTakipSistemi.sln` solution file in Visual Studio and build the project.
3. **Run:** Run the executable `StokTakipSistemi.exe` (or the name of your main form's executable).

## Usage

* **Adding a Product:**  Open the "Ürün Ekleme" form and enter the product details.
* **Managing Customers:** Use the "Müşteri Ekleme" form to add, edit, or delete customer information.
* **Generating Reports:** Select the desired report from the "Raporlama" section.
