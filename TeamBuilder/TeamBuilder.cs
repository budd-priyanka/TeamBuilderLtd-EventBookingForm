/**************** BUSINESS APPLICATION PROGRAMMING ASSIGNMENT - 5 ****************
 * Student Name: B Priyanka
 * Student ID: 19230305
 * Date: 27/11/2019
 * Assignment: 5 [ MS806 (2019_20) ]
 * Assignment: An application for TeamBuilder Ltd, 
 * a company that provides team building events in locations 
 * across Ireland. 
 * All the files will be created in the following location:
 * closingStockPlaces file: ~<PATH_TO_YOUR_PROJECT_DIRECTORY>/bin/Debug/closingStockPlaces.txt
 * booking record files: ~<PATH_TO_YOUR_PROJECT_DIRECTORY>/bin/Debug/BookingRecords/<SYSTEM_DATE>.txt
 * management report files: ~<PATH_TO_YOUR_PROJECT_DIRECTORY>/bin/Debug/ManagementReports/managementReport<SYSTEM_DATE_AND_TIME>.txt
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TeamBuilder
{
    public partial class TeamBuilder : Form
    {
        public TeamBuilder()
        {
            InitializeComponent();
        }

        //Constants for the file storage.
        string BASE_DIRECTORY = AppDomain.CurrentDomain.BaseDirectory;
        const string BOOKINGS_FOLDER_NAME = "BookingRecords";
        const string MANAGEMENT_FOLDER_NAME = "ManagementReports";
        const string CLOSING_STOCK_PLACES_FILE_NAME = "closingStockPlaces.txt";
        const string MANAGEMENT_REPORT_FILE_NAME = "managementReport";
        string BOOKING_FILE_NAME = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + ".txt";

        //Constants that will be used as markers in/from the file.
        const string BOOKING_NUMBER = "## Booking Number: ";
        const string EVENT_NAME = "Event Name: ";
        const string EVENT_LOCATION = "Event Location: ";
        const string MEAL_TYPE = "Meal Type: ";
        const string QUANTITY_OF_PLACES = "Quantity of Places: ";
        const string BOOKING_COST = "Booking Cost: ";
        const string BOOKING_RECORDED_TIME = "Booking Recorded on: ";
        const string RECORD_BOOKING_SEPERATOR = "******************************             ******************************";
        const string EVENT_BOOKING_SEPERATOR = "----------------------------------------------------------------";


        /*Min and max values for generating a 6 digit random number.
         * MIN_LIMIT (Inclusive), MAX_LIMIT (Exclusive)
         * Modify these values to increase/decrease the range of bookings permitted.
         */
        const int MIN_LIMIT = 100000;
        const int MAX_LIMIT = 1000000;

        //Global constants
        string[] eventNameArray = { "Murder Mystery Weekend", "CSI Weekend", "The Great Outdoors", "The Chase", "Digital Refresh", "Action Photography", "Team Ryder Cup", "Abseiling", "War Games", "Find Wally" };
        int[] eventFeesArray = { 600, 1000, 1500, 1800, 599, 999, 619, 499, 1999, 799 };

        string[] locationNameArray = { "Cork", "Dublin", "Galway", "Belmullet", "Belfast" };

        string[] mealTypeArray = { "Full Meal", "Half Board", "Breakfast Only", "None" };

        int[,] eventLocationPriceMatrix = { { 1100, 930, 1050, 1210, 790 },
            { 1750, 1495, 1675, 1915, 1285 },
            { 2500, 2160, 2400, 2720, 1880 },
            { 3300, 2790, 3150, 3630, 2370 },
            { 1099, 929, 1049, 1209, 789 },
            { 2249, 1824, 2124, 2524, 1474 },
            { 1369, 1114, 1294, 1534, 904 },
            { 999, 829, 949, 1109, 689 },
            { 3499, 2989, 3349, 3829, 2569 },
            { 2049, 1624, 1924, 2324, 1274} };

        int[,] eventMealPriceMatrix = { { 99, 75, 24, 0 },
            { 149, 113, 36, 0 },
            { 198, 150, 48, 0 },
            { 297, 225, 72, 0 },
            { 99, 75, 24, 0 },
            { 248, 188, 60, 0 },
            { 149, 113, 36, 0 },
            { 99, 75, 24, 0 },
            { 297, 225, 72, 0 },
            { 248, 188, 60, 0 } };

        int[,] maximumStockPlacesMatrix = { { 35, 67, 12, 77, 32 },
            { 28, 3, 34, 12, 7 },
            { 23, 2, 6, 4, 3 },
            { 12, 6, 9, 4, 6 },
            { 2, 0, 7, 5, 8 },
            { 1, 8, 4, 7, 4 },
            { 16, 24, 40, 4, 12 },
            { 3, 7, 45, 3, 3 },
            { 45, 12, 56, 12, 23 },
            { 0, 0, 3, 0, 0 } };

        int[,] availableStockPlacesMatrix = { { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 },
            { -1, -1, -1, -1, -1 } }; //To store the available stock places from previous day.

        int numberOfPlacesInput = 1;

        int eventSelectedIndex = -1;
        int locationSelectedIndex = -1;
        int mealSelectedIndex = 3;//By default "No Meal" option is selected

        int totalCostTextLabelValue = 0; //To store the total cost 
        int maxEventNameSize = 0; //To store the size of the largest name among the events.

        List<int> transactionNumbersList = new List<int>();//To store all the transaction numbers.
        int bookingNumber = -1;

        List<string> bookingListboxTracker = new List<string>();//To keep track of the indices of the bookings in the list.
        List<string> confirmedBookingTracker = new List<string>();//To keep track of indices of the bookings that have been confirmed.

        /* Application first checks for the availibility of BookingRecords folder and creates if not.
         * Also checks for the availibility of closingStockPlaces file and creates if not.
         * Proceeds on successfull creation of both else exits the application.
         */
        private void TeamBuilder_Load(object sender, EventArgs e)
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);//Saves closing stock values into the file upon closing the application without using the exit button.

            //To get the size of the largest event.
            for(int i = 0; i< eventNameArray.Length; i++)
            {
                int wordSize = eventNameArray[i].Length;
                if(wordSize > maxEventNameSize)
                {
                    maxEventNameSize = wordSize;
                }
            }

            if (createFolder(BOOKINGS_FOLDER_NAME) && createClosingStockPlacesFile(BASE_DIRECTORY + @"\" + CLOSING_STOCK_PLACES_FILE_NAME))
            {
                eventsPanel.Visible = true;
                reviewLabel.Visible = true;
                bookingReviewListbox.Visible = true;
                reviewButtonsPanel.Visible = true;
                printedCertificateLabel.Visible = true;
                bookingCostLabel.Visible = true;
                totalCostLabel.Visible = true;
            }
            else
            {
                this.Close();
            }
        }

        //Writes to the closingStockPlaces.txt and closes the application when the user opts to exit.
        private void OnApplicationExit(object sender, EventArgs e)
        {
            if(writeToClosingStockFile())
            {
                try
                {
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Failed to close the application. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exitButton.Focus();
                }
            }
            else
            {
                MessageBox.Show("Closing Stock Places failed to be recorded. Please try again.", "Booking Message: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exitButton.Focus();
            }
        }

        //Creates the folder with the provided folderName.
        private bool createFolder(string folderName)
        {
            string path = BASE_DIRECTORY + folderName;
            bool status = false;
            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("Booking folder created at location: " + path);
                }
                status = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Folder creation failed: {0}", e.ToString());
                status = false;
                MessageBox.Show("Failed to create Bookings folder.", "File IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //Fetch the respective fares based on the user selection options and calculates the total cost of the event.
        private void populateTotalCostLabel()
        {
            string costDisplayText;
            if (eventSelectedIndex > -1 && locationSelectedIndex == -1 && mealSelectedIndex == 3)
            {
                totalCostTextLabelValue = eventFeesArray[eventSelectedIndex];
                costDisplayText = totalCostTextLabelValue.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));
                totalCostLabel.Text = costDisplayText;
            }
            else if (eventSelectedIndex > -1 && locationSelectedIndex > -1 && mealSelectedIndex == 3)
            {
                totalCostTextLabelValue = 0;
                totalCostTextLabelValue += eventLocationPriceMatrix[eventSelectedIndex, locationSelectedIndex];
                costDisplayText = totalCostTextLabelValue.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));
                totalCostLabel.Text = costDisplayText;
            }
            else if (eventSelectedIndex > -1 && locationSelectedIndex > -1 && mealSelectedIndex > -1)
            {
                totalCostTextLabelValue = 0;
                totalCostTextLabelValue += eventLocationPriceMatrix[eventSelectedIndex, locationSelectedIndex];
                totalCostTextLabelValue += eventMealPriceMatrix[eventSelectedIndex, mealSelectedIndex];
                totalCostTextLabelValue = totalCostTextLabelValue * numberOfPlacesInput;
                costDisplayText = totalCostTextLabelValue.ToString("C2", CultureInfo.CreateSpecificCulture("ga-IE"));
                totalCostLabel.Text = costDisplayText;
                if (!saveChangesButton.Visible)
                {
                    addToBookingButton.Enabled = true;
                    addToBookingButton.Focus();
                }
            }
        }

        /*Create closingStockPlaces file if not exists.
         * Returns true on successful creation.
         * Returns false on error.
         */
        private bool createClosingStockPlacesFile(string path)
        {
            bool status = true;
            try
            {
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                else if (File.Exists(path))
                {
                    status = readClosingStockPlacesFile(path);
                }
            }
            catch
            {
                MessageBox.Show("Failed to create closingStockPlaces.txt file.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
                exitButton.Focus();
            }
            return status;
        }

        /*Reads closingStockPlaces file and replaces the values in closingStockPlacesMatrix Array.
         * Returns true on successful parsing.
         * Returns false on error.
         */
        private bool readClosingStockPlacesFile(string path)
        {
            bool readingStatus = true;
            int convertedValue = 0;
            StreamReader reader = new StreamReader(path);

            try
            {
                int fileLength = File.ReadLines(path).Count();

                if (fileLength != 0)
                {
                    for (int l = 0; l < fileLength; l++)
                    {
                        string line = reader.ReadLine();

                        for (int i = 0; i < eventNameArray.Length; i++)
                        {
                            for (int j = 0; j < locationNameArray.Length; j++)
                            {
                                string identifier = eventNameArray[i] + "|" + locationNameArray[j] + ": ";
                                if ((line != null) && (line.Contains(identifier)))
                                {
                                    int index = line.IndexOf(": ") + 2; //Adding 2 additional indices for ": ". 
                                    string stockValue = line.Substring(index);

                                    if (int.TryParse(stockValue, out convertedValue))
                                    {
                                        availableStockPlacesMatrix[i, j] = convertedValue;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error during converting field: " + identifier);
                                        MessageBox.Show("Error during value conversion.", "File Manipulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        readingStatus = false;
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to read closingStockPlaces.txt file.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                readingStatus = false;
                exitButton.Focus();
            }
            finally
            {
                reader.Close();
            }
            return readingStatus;
        }

        //Writes into the closingStockPlaces.txt and then closes the application.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (writeToClosingStockFile())
            {
                try
                {
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Failed to close the application. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exitButton.Focus();
                }
            }
            else
            {
                MessageBox.Show("Closing Stock Places failed to be recorded. Please try again.", "Booking Message: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exitButton.Focus();
            }
        }

        //Records the remaining quantity of places into a text file for following day bookings.
        private bool writeToClosingStockFile()
        {
            bool status = false;

            StreamWriter writer = new StreamWriter(BASE_DIRECTORY + @"\" + CLOSING_STOCK_PLACES_FILE_NAME);

            try
            {
                for(int i = 0; i < eventNameArray.Length; i++)
                {
                    for (int j = 0; j < locationNameArray.Length; j++)
                    {
                        if (availableStockPlacesMatrix[i,j] != -1)
                        {
                            string line = eventNameArray[i] + "|" + locationNameArray[j] + ": "
                                + availableStockPlacesMatrix[i, j];
                            writer.WriteLine(line);
                        }
                    }
                }
                writer.Close();
                status = true;
            }
            catch
            {
                status = false;
                MessageBox.Show("Closing Stock Places failed to be recorded.", "Booking Message: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exitButton.Focus();
            }
            finally
            {
                writer.Close();
            }
            return status;
        }

        //Enables the locationListbox only after the selection made in the eventsListbox
        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventSelectedIndex = eventsListBox.SelectedIndex;

            locationHeading.Enabled = true;
            locationListbox.Enabled = true;
            mealHeading.Enabled = true;
            mealRadioGroup.Enabled = true;
            clearButton.Enabled = true;
            
            showQuantityErrorLabel();
            setEventLocationLabel();
            populateTotalCostLabel();
        }

        //Shows the error label if the user selection of event and location has insufficient quantity of places.
        private void showQuantityErrorLabel()
        {
            if (eventSelectedIndex > -1 && locationSelectedIndex > -1)
            {
                int availableStockValue = availableStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex];
                int maximumStockValue = maximumStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex];

                quantityPanel.Enabled = true;
                addToBookingButton.Enabled = true;
                quantityErrorLabel.Visible = false;

                if (availableStockValue == 0 || maximumStockValue == 0)
                {
                    quantityPanel.Enabled = false;
                    addToBookingButton.Enabled = false;
                    quantityErrorLabel.Visible = true;

                    locationListbox.Focus();
                }
            }
        }

        private void FullBoardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealSelectedIndex = 0;
            populateTotalCostLabel();
        }

        private void HalfBoardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealSelectedIndex = 1;
            populateTotalCostLabel();
        }

        private void BreakfastOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealSelectedIndex = 2;
            populateTotalCostLabel();
        }

        private void NoMealRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealSelectedIndex = 3;
            populateTotalCostLabel();
        }

        //Clear all the selections made
        private void ClearButton_Click(object sender, EventArgs e)
        {
            reset();
        }

        //Resets all the panels to its initial settings.
        private void reset()
        {
            if(!saveChangesButton.Visible)
            {
                bookingReviewListbox.ClearSelected();
                editButton.Visible = true;
                deleteButton.Visible = false;
                cancelEditingButton.Visible = false;
            }

            eventsListBox.ClearSelected();
            locationListbox.ClearSelected();
       
            if (fullBoardRadioButton.Checked)
            {
                fullBoardRadioButton.Checked = false;
            }
            else if (halfBoardRadioButton.Checked)
            {
                halfBoardRadioButton.Checked = false;
            }
            else if (breakfastOnlyRadioButton.Checked)
            {
                breakfastOnlyRadioButton.Checked = false;
            }

            noMealRadioButton.Checked = true;

            mealRadioGroup.Enabled = false;
            locationListbox.Enabled = false;
            addToBookingButton.Enabled = false;
            quantityPanel.Enabled = false;
            clearButton.Enabled = false;
            editButton.Enabled = false;

            stockCounter.Value = 1;
            totalCostLabel.Text = "";
            eventAndLocationLabel.Text = "";

            totalCostTextLabelValue = 0;
            eventSelectedIndex = -1;
            locationSelectedIndex = -1;
            mealSelectedIndex = 3;

            if (bookingReviewListbox.Items.Count > 0)
            {
                confirmButton.Enabled = true;
            }
            else
            {
                confirmButton.Enabled = false;
            }

            eventsListBox.Focus();
        }

        //Populates the booking review listbox.
        private void populateBookingReviewListbox()
        {
            bookingReviewListbox.Enabled = true;

            string reviewListboxText = manageBookingReviewListboxItem();
            if(reviewListboxText.Length != 0)
            {
                string indicesList = eventSelectedIndex + ";" + locationSelectedIndex + ";" + mealSelectedIndex + ";" + numberOfPlacesInput + ";" + totalCostLabel.Text;

                bookingListboxTracker.Add(indicesList);
                bookingReviewListbox.Items.Add(reviewListboxText);

                //Populating final confirmation list box.
                finalConfirmationListbox.Items.Add(reviewListboxText);

                reset();
            }
        }
        //Selects the respective items in the list boxes for the event selected for editing.
        private string manageBookingReviewListboxItem()
        {
            string reviewListboxText = "";
            numberOfPlacesInput = Convert.ToInt32(stockCounter.Value);

            int availableStockPlaces = availableStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex];
            int maximumStockPlaces = availableStockPlaces;

            //Fetching from maximumStockPlacesMatrix if the event location combination was not used in early transactions.
            if (availableStockPlaces == -1)
            {
                maximumStockPlaces = maximumStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex];
            }
            if (maximumStockPlaces != 0 && numberOfPlacesInput <= maximumStockPlaces)
            {
                if (availableStockPlaces == -1)
                {
                    availableStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex] = maximumStockPlaces - numberOfPlacesInput;
                }
                else
                {
                    availableStockPlacesMatrix[eventSelectedIndex, locationSelectedIndex] = availableStockPlaces - numberOfPlacesInput;
                }

                 reviewListboxText = eventNameArray[eventSelectedIndex] + " Event with " +
                    numberOfPlacesInput + " places at " +
                    locationNameArray[locationSelectedIndex] + " with " +
                    mealTypeArray[mealSelectedIndex] + " Meal. ESTIMATED TOTAL COST: " +
                    totalCostLabel.Text;                
            }
            else
            {
                string errorMessage = "Only " + availableStockPlaces + " places are available at " + locationNameArray[locationSelectedIndex] + " for " + eventNameArray[eventSelectedIndex];
                MessageBox.Show(errorMessage, "Places Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockCounter.Focus();
            }
            return reviewListboxText;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            confirmationPanel.Visible = true;
        }

        //Creates the booking file within the BookingRecords folder using the current system date and time.
        private bool createBookingsFile( int bookingNumber)
        {
            bool status = false;
            string path = BASE_DIRECTORY + BOOKINGS_FOLDER_NAME + "/" + BOOKING_FILE_NAME;
            try
            {
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                writeToBookingFile(bookingNumber);  
            }
            catch
            {
                MessageBox.Show("Failed to create bookings file.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
            return status;
        }

        //Writes all the user specified booking information onto the booking text file.
        private bool writeToBookingFile( int bookingNumber)
        {
            bool status = false;

            StreamWriter writer = File.AppendText(BASE_DIRECTORY + @"\" + BOOKINGS_FOLDER_NAME + "/" + BOOKING_FILE_NAME);

            try
            {
                writer.WriteLine("");
                writer.WriteLine(BOOKING_NUMBER + bookingNumber);
                writer.WriteLine("");
                for (int i = 0; i < bookingListboxTracker.Count; i++ )
                {
                    string[] bookingToBeRecorded = bookingListboxTracker[i].Split(';');

                    writer.WriteLine(EVENT_NAME + eventNameArray[System.Convert.ToInt32(bookingToBeRecorded[0])]);
                    writer.WriteLine(EVENT_LOCATION + locationNameArray[System.Convert.ToInt32(bookingToBeRecorded[1])]);
                    writer.WriteLine(MEAL_TYPE + mealTypeArray[System.Convert.ToInt32(bookingToBeRecorded[2])]);
                    writer.WriteLine(QUANTITY_OF_PLACES + bookingToBeRecorded[3]);
                    writer.WriteLine(BOOKING_COST + bookingToBeRecorded[4]);
                    writer.WriteLine(BOOKING_RECORDED_TIME + DateTime.Now.ToString("F"));
                    writer.WriteLine(EVENT_BOOKING_SEPERATOR);

                    string confirmedRecord = bookingNumber + ";" + bookingListboxTracker[i];
                    confirmedBookingTracker.Add(confirmedRecord);
                }

                writer.WriteLine(RECORD_BOOKING_SEPERATOR);
                writer.Close();

                MessageBox.Show("Booking recorded successfully.", "Booking Message: Success ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                confirmButton.Enabled = false;
                bookingListboxTracker.Clear();
                bookingReviewListbox.Items.Clear();
                finalConfirmationListbox.Items.Clear();
                confirmationPanel.Visible = false;
                eventsListBox.Focus();
            }
            catch
            {
                MessageBox.Show("Booking failed to be recorded.", "Booking Message: Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmButton.Focus();
            }
            finally
            {
                writer.Close();
            }

            return status;
        }

        //Adds the user specified event information to the bookingReviewListbox.
        private void AddToBookingButton_Click(object sender, EventArgs e)
        {
            if (stockCounter.Value < 0)
            {
                MessageBox.Show("Value cannot be negative.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockCounter.Value = 1;
                stockCounter.Focus();
            }
            else if (stockCounter.Value == 0)
            {
                MessageBox.Show("Booking is not possible if quantity of places is zero.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockCounter.Value = 1;
                stockCounter.Focus();
            }
            else
            {
                populateBookingReviewListbox();
            }
            if (bookingReviewListbox.Items.Count > 0)
            {
                confirmButton.Enabled = true;
            }
            else
            {
                confirmButton.Enabled = false;
            }
        }

        // Generate a 6 digit random number  
        public int randomBookingNumberGenerator()
        {
            Random random = new Random();
            return random.Next(MIN_LIMIT, MAX_LIMIT);
        }

        private void LocationListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            locationSelectedIndex = locationListbox.SelectedIndex;
            quantityPanel.Enabled = true;
            addToBookingButton.Enabled = true;

            showQuantityErrorLabel();
            setEventLocationLabel();
            populateTotalCostLabel();
        }

        //Sets the selected event and location near the Quantity of places label.
        private void setEventLocationLabel()
        {
            if (eventSelectedIndex > -1 && locationSelectedIndex > -1)
            {
                string eventAndLocationLabelText = eventNameArray[eventSelectedIndex] + " at " + locationNameArray[locationSelectedIndex];
                eventAndLocationLabel.Text = eventAndLocationLabelText;
            }
        }
        
        private void BookingReviewListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToBookingButton.Enabled = false;
            editButton.Enabled = true;
            clearButton.Enabled = true;
        }

        //Makes the required changes to the panel to enable the user to edit the selected event.
        private void EditButton_Click(object sender, EventArgs e)
        {
            int convertedValue;
            editButton.Visible = false;
            saveChangesButton.Visible = true;
            deleteButton.Visible = true;
            cancelEditingButton.Visible = true;
            addToBookingButton.Enabled = false;
            confirmButton.Enabled = false;

            string[] toBeEditedIndices = bookingListboxTracker[bookingReviewListbox.SelectedIndex].Split(';');

            if(toBeEditedIndices.Length > 0)
            {
                if (int.TryParse(toBeEditedIndices[0], out convertedValue))
                {
                    eventSelectedIndex = convertedValue;
                    eventsListBox.SelectedIndex = eventSelectedIndex;
                }
                else
                {
                    eventSelectedIndex = -1;
                    Console.WriteLine("Error during converting the eventSelectedIndex from bookingListboxTracker.");
                    MessageBox.Show("Error during value conversion.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (int.TryParse(toBeEditedIndices[1], out convertedValue))
                {
                    locationListbox.Enabled = true;
                    locationSelectedIndex = convertedValue;
                    locationListbox.SelectedIndex = locationSelectedIndex;
                }
                else
                {
                    locationSelectedIndex = -1;
                    Console.WriteLine("Error during converting the locationSelectedIndex from bookingListboxTracker.");
                    MessageBox.Show("Error during value conversion.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (int.TryParse(toBeEditedIndices[2], out convertedValue))
                {
                    mealRadioGroup.Enabled = true;
                    mealSelectedIndex = convertedValue;

                    switch (mealSelectedIndex)
                    {
                        case 0:
                            fullBoardRadioButton.Checked = true;
                            break;
                        case 1:
                            halfBoardRadioButton.Checked = true;
                            break;
                        case 2:
                            breakfastOnlyRadioButton.Checked = true;
                            break;
                        default:
                            noMealRadioButton.Checked = true;
                            break;
                    }
                }
                else
                {
                    mealSelectedIndex = 3;
                    Console.WriteLine("Error during converting the mealSelectedIndex from bookingListboxTracker.");
                    MessageBox.Show("Error during value conversion.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (int.TryParse(toBeEditedIndices[3], out convertedValue))
                {
                    stockCounter.Value = (decimal)convertedValue;
                }
                else
                {
                    Console.WriteLine("Error during converting the quantity of places from bookingListboxTracker.");
                    MessageBox.Show("Error during value conversion.", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                totalCostLabel.Text = toBeEditedIndices[4];
                quantityPanel.Enabled = true;
            }

        }

        //To alert the user if the provided quantity of places is not available to book for an event.
        private void StockCounter_ValueChanged(object sender, EventArgs e)
        {
            if (stockCounter.Value < 0)
            {
                MessageBox.Show("Value cannot be negative.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stockCounter.Value = 1;
                stockCounter.Focus();
            }
                       
                numberOfPlacesInput = (int)stockCounter.Value;
                populateTotalCostLabel();
            
        }

        //Saves the changes made to the event selected for editing. 
        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            int bookingReviewSelectedIndex = bookingReviewListbox.SelectedIndex;
            if(eventSelectedIndex == -1 || locationSelectedIndex == -1)
            {
                MessageBox.Show("Please ensure all fields are selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                eventsListBox.Focus();
            }
            else
            {
                string reviewListboxText = manageBookingReviewListboxItem();
                if (reviewListboxText.Length != 0)
                {
                    string indicesList = eventSelectedIndex + ";" + locationSelectedIndex + ";" + mealSelectedIndex + ";" + numberOfPlacesInput + ";" + totalCostLabel.Text;

                    bookingListboxTracker[bookingReviewSelectedIndex] = indicesList;
                    bookingReviewListbox.Items[bookingReviewSelectedIndex] = reviewListboxText;
                    finalConfirmationListbox.Items[bookingReviewSelectedIndex] = reviewListboxText;

                    reset();

                    saveChangesButton.Visible = false;
                    deleteButton.Visible = false;
                    editButton.Enabled = true;
                    editButton.Visible = true;
                }
                clearButton.Enabled = true;
            }
        }

        //Reverts the changes made to an event which is selected to be edited.
        private void CancelEditButton_Click(object sender, EventArgs e)
        {
            bookingReviewListbox.ClearSelected();
            quantityErrorLabel.Visible = false;
            saveChangesButton.Visible = false;
            deleteButton.Visible = false;
            cancelEditingButton.Visible = false;
            editButton.Visible = true;
            reset();
        }

        //Deletes the selected event.
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int bookingReviewSelectedIndex = bookingReviewListbox.SelectedIndex;
            if(bookingReviewSelectedIndex >= 0)
            {
                bookingListboxTracker.RemoveAt(bookingReviewSelectedIndex);
                bookingReviewListbox.Items.RemoveAt(bookingReviewSelectedIndex);

                saveChangesButton.Visible = false;
                deleteButton.Visible = false;
                clearButton.Enabled = false;

                reset();
                eventsListBox.Focus();

                if (bookingReviewListbox.Items.Count > 0)
                {
                    confirmButton.Enabled = true;
                }
                else
                {
                    confirmButton.Enabled = false;
                }
            }
        }

        /*Creates a folder named ManagementReports on clicking the Generate Report button.
         * Calls writeToManagementReport() to write onto the respective text file.
         */
        private void GenerateManagementReportButton_Click(object sender, EventArgs e)
        {
            string tail = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + ".txt";
            string path = BASE_DIRECTORY + @"\" + MANAGEMENT_FOLDER_NAME + "/" + MANAGEMENT_REPORT_FILE_NAME + tail;

            if(createFolder(MANAGEMENT_FOLDER_NAME))
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        FileStream fs = File.Create(path);
                        fs.Close();
                    }
                    writeToManagementReport(path);
                }
                catch
                {
                    MessageBox.Show("Failed to create Management Report.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    exitButton.Focus();
                }
            }
        }

        //Populates the management report of available event places into Management Report text file.
        private void writeToManagementReport(string path)
        {
            string reportingTimeLabel = "Reporting Time: ".ToUpper();
            string confirmedBookingDescription = "Booking Number --> Event name @ Location --> quantity of places sold --> event cost (€)".ToUpper();
            string tableDescription = "Available event places".ToUpper();
            string totalBookingsLabel = "Total Number of Bookings: ".ToUpper();
            string totalCostLabel = "Total Booking Cost: €".ToUpper();
            string averageCostLabel = "Average Booking Cost: €".ToUpper();
            string seperator = "******************************************************************************\n";

            decimal totalCost = 0.0m;
            decimal averageCost = 0.0m;
            decimal convertedValue = 0.0m;
            int totalBookings = confirmedBookingTracker.Count();

            StreamWriter writer = new StreamWriter(path);
            try
            {
                writer.WriteLine(reportingTimeLabel + DateTime.Now.ToString("F"));
                writer.WriteLine("");
                writer.WriteLine(confirmedBookingDescription);
                writer.WriteLine(seperator);
                
                for(int i = 0; i<totalBookings; i++)
                {
                    string[] confirmedValues = confirmedBookingTracker[i].Split(';');

                    string record = confirmedValues[0] + " --> " + 
                        eventNameArray[Convert.ToInt32(confirmedValues[1])] + " @ " + locationNameArray[Convert.ToInt32(confirmedValues[2])] + " --> " +
                        confirmedValues[4] + " Place(s) --> " +
                        confirmedValues[5];

                    writer.WriteLine(record);

                    //Fetching the cost out of stored values
                    string costValue = confirmedValues[5].Substring(1);
                    if (decimal.TryParse(costValue, out convertedValue))
                    {
                        totalCost += convertedValue;
                    }
                    else
                    {
                        Console.WriteLine("Error during converting field: " + costValue);
                        MessageBox.Show("Error during value conversion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                writer.WriteLine(seperator);
                writer.WriteLine(tableDescription);
                writer.WriteLine("");
                   
                string tableHeader = "";
                int temp = 0;
                while(temp < maxEventNameSize)
                {
                    tableHeader += " ";
                    temp++;
                }

                for (int i=0; i<locationNameArray.Length; i++)
                {
                    tableHeader += "\t" + locationNameArray[i].ToUpper();
                }

                writer.WriteLine(tableHeader);

                for(int i = 0; i< eventNameArray.Length; i++)
                {
                    string row = eventNameArray[i].ToUpper();
                    //Hack to set first column in same size.
                    temp = row.Length;
                    while (temp < maxEventNameSize)
                    {
                        row += " ";
                        temp++;
                    }

                    for (int j = 0; j < locationNameArray.Length; j++)
                    {
                        if(availableStockPlacesMatrix[i, j] == -1)
                        {
                            row += "\t" + maximumStockPlacesMatrix[i, j] + "\t";
                        }
                        else
                        {
                            row += "\t" + availableStockPlacesMatrix[i, j] + "\t";
                        }
                    }
                    writer.WriteLine(row);
                }

                writer.WriteLine("");
                writer.WriteLine(seperator);
                writer.WriteLine(totalBookingsLabel + totalBookings);
                writer.WriteLine(totalCostLabel + totalCost);

                try
                {
                    averageCost = Math.Round((totalCost / totalBookings),2);
                }
                catch
                {
                    string errorMessage = "Encountered Divide by zero error as no bookings have been made thus far.\n Remaining details are recorded in the file.";
                    Console.WriteLine("Divide by zero error. Total bookings: " + totalBookings);
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                writer.WriteLine(averageCostLabel + averageCost);
                writer.WriteLine(seperator);

                writer.Close();

                MessageBox.Show("Management report has been generated at " + path, "Management Report Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Failed to write Management Report. Please try again.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                generateManagementReportButton.Focus();
            }
            finally
            {
                writer.Close();
            }
        }

        //Generates a random number and records it in the booking text file
        private void OkButton_Click(object sender, EventArgs e)
        {
            do
            {
                bookingNumber = randomBookingNumberGenerator();
            } while (transactionNumbersList.Contains(bookingNumber));

            createBookingsFile(bookingNumber);
        }

        //Takes back to the booking screen.
        private void CancelButton_Click(object sender, EventArgs e)
        {
            confirmationPanel.Visible = false;
        }
    }
}
