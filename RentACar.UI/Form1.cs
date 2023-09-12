using RentACar.Domain.Entities;
using RentACar.Domain.Enums;
using RentACar.Infrastructure.Data;
using RentACar.Infrastructure.Repositories;

namespace RentACar.UI
{
    public partial class Form1 : Form
    {
        private static RentACarDBContext _db;

        private static CarRepository _carRepository;
        private static Car _car;

        private static CustomerRepository _customerRepository;
        private static Customer _customer;

        private static CarParkRepository _carParkRepository;
        private static CarPark _carPark;

        private static CarParkFloorRepository _carParkFloorRepository;
        private static CarParkFloor _carParkFloor;

        private static CarCustomerRepository _carCustomerRepository;
        private static CarCustomer _carCustomer;

        public Form1()
        {
            InitializeComponent();
            _db = new RentACarDBContext();

            _carRepository = new CarRepository();
            _car = new Car();

            _customerRepository = new CustomerRepository();
            _customer = new Customer();

            _carParkRepository = new CarParkRepository();
            _carPark = new CarPark();

            _carParkFloorRepository = new CarParkFloorRepository();
            _carParkFloor = new CarParkFloor();

            _carCustomerRepository = new CarCustomerRepository();
            _carCustomer = new CarCustomer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvCars.DataSource = _db.Cars.ToList();

            object[] carModels = { CarModel.Fiat_Egea, CarModel.Renault_Clio, CarModel.BMW_M5 };
            cbCarModel.Items.AddRange(carModels);

            dgvCustomers.DataSource = _db.Customers.ToList();

            dgvCarParks.DataSource = _db.CarParks.ToList();

            dgvCarParkFloors.DataSource = _db.CarParkFloors.ToList();

            dgvCarCustomers.DataSource = _db.CarCustomers.ToList();
        }

        //------------------------------------------ CARS -----------------------------------------------------

        private void btnCarCreate_Click(object sender, EventArgs e)
        {
            _car.CarModel = (CarModel)cbCarModel.SelectedItem;
            _carRepository.Create(_car);
            MessageBox.Show("Araç baþarýyla eklendi.");

        }

        private void cbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCarCreate.Enabled = true;
        }

        private void btnCarDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCars.SelectedCells[0].Value);
            _carRepository.Delete(id);
            MessageBox.Show("Araç baþarýyla silindi.");

        }

        private void dgvCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCarDelete.Enabled = true;
                btnCarUpdate.Enabled = true;

                cbCarModel.Text = dgvCars.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void btnCarUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCars.SelectedCells[0].Value);
            _car = _carRepository.GetById(id);
            _car.CarModel = (CarModel)cbCarModel.SelectedItem;
            _carRepository.Update(_car);
            MessageBox.Show("Güncelleme iþlemi baþarýyla gerçekleþti.");
        }

        //----------------------------------------- CUSTOMERS ---------------------------------------------------

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            _customer.CustomerFirstName = txtCustomerFirstname.Text;
            _customer.CustomerLastname = txtCustomerLastname.Text;
            _customerRepository.Create(_customer);
            MessageBox.Show("Müþteri baþarýyla eklendi.");
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCustomers.SelectedCells[0].Value);
            _customer = _customerRepository.GetById(id);
            _customer.CustomerFirstName = txtCustomerFirstname.Text;
            _customer.CustomerLastname = txtCustomerLastname.Text;
            _customerRepository.Update(_customer);
            MessageBox.Show("Güncelleme iþlemi baþarýyla gerçekleþti.");
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCustomers.SelectedCells[0].Value);
            _customerRepository.Delete(id);
            MessageBox.Show("Müþteri baþarýyla silindi.");
        }

        private void txtCustomerFirstname_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerFirstname.TextLength > 0 && txtCustomerLastname.TextLength > 0)
            {
                btnCustomerCreate.Enabled = true;
            }
            else
            {
                btnCustomerCreate.Enabled = false;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCustomerDelete.Enabled = true;
                btnCustomerUpdate.Enabled = true;

                txtCustomerFirstname.Text = dgvCustomers.SelectedRows[0].Cells[1].Value.ToString();
                txtCustomerLastname.Text = dgvCustomers.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        //----------------------------------------- CARPARKS ---------------------------------------------------

        private void btnCarParkCreate_Click(object sender, EventArgs e)
        {
            _carPark.CarParkNo = Convert.ToInt32(nudCarParkNo.Value);
            _carParkRepository.Create(_carPark);
            MessageBox.Show("Park numarasý baþarýyla eklendi.");
        }

        private void btnCarParkUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarParks.SelectedCells[0].Value);
            _carPark = _carParkRepository.GetById(id);
            _carPark.CarParkNo = Convert.ToInt32(nudCarParkNo.Value);
            _carParkRepository.Update(_carPark);
            MessageBox.Show("Güncelleme iþlemi baþarýyla gerçekleþti.");
        }

        private void btnCarParkDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarParks.SelectedCells[0].Value);
            _carParkRepository.Delete(id);
            MessageBox.Show("Park numarasý baþarýyla silindi.");
        }

        private void dgvCarParks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCarParkDelete.Enabled = true;
                btnCarParkUpdate.Enabled = true;

                nudCarParkNo.Value = Convert.ToDecimal(dgvCarParks.SelectedRows[0].Cells[1].Value);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void nudCarParkNo_ValueChanged(object sender, EventArgs e)
        {
            btnCarParkCreate.Enabled = true;
        }

        //---------------------------------------- CARPARKFLOOR ---------------------------------------------------

        private void btnCarParkFloorCreate_Click(object sender, EventArgs e)
        {
            _carParkFloor.CarParkFloorNo = Convert.ToInt32(nudCarkParkFloorNo.Value);
            _carParkFloorRepository.Create(_carParkFloor);
            MessageBox.Show("Park kat numarasý baþarýyla eklendi.");
        }

        private void btnCarParkFloorUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarParkFloors.SelectedCells[0].Value);
            _carParkFloor = _carParkFloorRepository.GetById(id);
            _carParkFloor.CarParkFloorNo = Convert.ToInt32(nudCarkParkFloorNo.Value);
            _carParkFloorRepository.Update(_carParkFloor);
            MessageBox.Show("Güncelleme iþlemi baþarýyla gerçekleþti.");
        }

        private void btnCarParkFloorDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarParkFloors.SelectedCells[0].Value);
            _carParkFloorRepository.Delete(id);
            MessageBox.Show("Park kat numarasý baþarýyla silindi.");
        }

        private void dgvCarParkFloors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCarParkFloorDelete.Enabled = true;
                btnCarParkFloorUpdate.Enabled = true;

                nudCarkParkFloorNo.Value = Convert.ToDecimal(dgvCarParkFloors.SelectedRows[0].Cells[1].Value);
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void nudCarkParkFloorNo_ValueChanged(object sender, EventArgs e)
        {
            btnCarParkFloorCreate.Enabled = true;
        }

        //----------------------------------------- CARCUSTOMERS -------------------------------------------------

        private void btnCarCustomerCreate_Click(object sender, EventArgs e)
        {
            _carCustomer.PickUpDate = dtpPickUpDate.Value;
            _carCustomer.DeliveryDate = dtpDeliveryDate.Value;
            _carCustomerRepository.Create(_carCustomer);
            MessageBox.Show("Kiralama ve teslim tarihleri baþarýyla eklendi.");
        }

        private void btnCarCustomerUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarCustomers.SelectedCells[0].Value);
            _carCustomer = _carCustomerRepository.GetById(id);
            _carCustomer.PickUpDate = dtpPickUpDate.Value;
            _carCustomer.DeliveryDate = dtpDeliveryDate.Value;
            _carCustomerRepository.Update(_carCustomer);
            MessageBox.Show("Güncelleme iþlemi baþarýyla gerçekleþti.");
        }

        private void btnCarCustomerDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvCarCustomers.SelectedCells[0].Value);
            _carCustomerRepository.Delete(id);
            MessageBox.Show("Kiralama ve teslim tarihleri baþarýyla silindi.");
        }

        private void dgvCarCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnCarCustomerDelete.Enabled = true;
                btnCarCustomerUpdate.Enabled = true;

                dtpPickUpDate.Value = (DateTime)dgvCarCustomers.SelectedRows[0].Cells[5].Value;
                dtpDeliveryDate.Value = (DateTime)dgvCarCustomers.SelectedRows[0].Cells[6].Value;
            }
            catch (Exception u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpPickUpDate.Value <= DateTime.Now && dtpDeliveryDate.Value >= DateTime.Now)
            {
                btnCarCustomerCreate.Enabled = true;
            }
        }
    }
}