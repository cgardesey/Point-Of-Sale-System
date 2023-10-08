# Windows Forms POS Application

## Overview
This is a simple Windows Forms Point of Sale (POS) application for managing sales and inventory in a retail store. It allows users to add products to a cart, process sales, and track inventory levels.

## Features
- User-friendly graphical interface.
- Backup database
- Add products to the cart.
- Calculate total cost and generate receipts.
- Manage product inventory.
- Search for products by name.
- Role based permissions.
- Generate report on sales, products, stock level, users
- Receive alerts when stock levels are low

## Prerequisites
- Windows OS (Windows 7 or higher).
- .NET Framework 4.7.2 or higher.
- Visual Studio (2015 or higher) for development.

## Getting Started
1. Clone the repository to your local machine:

    ```bash
    git clone https://github.com/cgardesey/TMSA.git
    ```

2. Open the solution in Visual Studio.

3. Build the project to ensure all dependencies are resolved.

4. Run the application by pressing F5 or clicking the "Start" button in Visual Studio.

## Usage
- Login as an admin to add and manage users and products.
- Login as a cashier to process sales.
- Use the "Add to Cart" button to add products to the cart.
- Process the sale and generate a receipt.
- Check the inventory status in the admin panel.

## Configuration
- Modify the connection string in `app.config` to set up your database.
- Customize product categories, tax rates, and other settings in the configuration.

## Contributing
1. Fork the repository.
2. Create a new branch for your feature or bug fix: `git checkout -b feature/new-feature`.
3. Make your changes and commit them: `git commit -m "Add new feature"`.
4. Push to your fork: `git push origin feature/new-feature`.
5. Create a pull request to the main repository.

## License
This project is licensed under the MIT License - see the [MIT License](https://opensource.org/licenses/MIT) file for details.

## Acknowledgments
- Thanks to the creators of the Windows Forms framework for making GUI development easy.
- Shoutout to the .NET community for their valuable contributions.

## Contact
For any questions or issues, please contact:
- Cyril Gardesey <cyrilgardesey@gmail.com>

Happy coding!
