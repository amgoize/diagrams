# Bar Chart Generator in C#
This C# application generates and displays bar charts with randomly generated data using a graphical user interface built with Windows Forms. The program allows you to create new bar charts, save the generated data to a file, and load the data from a file to recreate the chart.

## Features

- **Generate Random Bar Chart**: Creates a bar chart with random lengths and colors for each bar.
- **Save Chart Data to File**: Saves the generated bar chart data (lengths and colors) to a text file (`2.txt`).
- **Load Chart Data from File**: Loads previously saved bar chart data from a text file (`1.txt`) and displays the chart.

## Usage

### Generating a Bar Chart

1. Run the application.
2. Click the "Generate" button to create a new bar chart with randomly generated values.
3. The chart will be displayed on the form, with each bar having a random length and color.

### Saving Chart Data

1. After generating a bar chart, click the "Save" button to save the data (bar lengths and colors) to `2.txt`.
2. The saved data will be stored in the format: `BarX:Length:R:G:B`, where `X` is the bar number, `Length` is the bar's length, and `R:G:B` represents the color in RGB format.

### Loading Chart Data

1. To recreate a bar chart from saved data, click the "Load" button.
2. The application will read data from `1.txt` and display the corresponding bar chart.
