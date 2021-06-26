# Description

This formula helps you to organize your series files (any file extension) into separate folders.

All files that don't match to the name and pattern, will be moved to **NotMatchFiles** folder _(this code is not too smart 😭 )_.

The files names must contain the correct name provided and the season and episode pattern, for example:

```ANYANY_ANYSERIES NAMEANY_ANY S06E02.any```
This file will be moved to a new folder S06 and renamed to SERIES NAME - S0602.any 
![image](https://user-images.githubusercontent.com/49722795/123515722-fcbe2b00-d66e-11eb-8b18-a28898434ed2.png)

## Requirements

- [Install and configure Richie](https://docs.ritchiecli.io/v2.11/getting-started/)

## Commands

```bash
rit zup seriesorganizer
```


## Demonstration

1 - Create a folder with all files

![image](https://user-images.githubusercontent.com/49722795/123515876-ad2c2f00-d66f-11eb-9c83-7bf0d57569eb.png)

2 - Run the formula command and insert the series name and the folder path of step 1

![image](https://user-images.githubusercontent.com/49722795/123515917-d64cbf80-d66f-11eb-8062-77014e8fe3f9.png)

3 - Done! Your files are now organized into folder per season.

** The **NotMatchFiles** folder contains the files that not match to the pattern 
 
![image](https://user-images.githubusercontent.com/49722795/123515963-26c41d00-d670-11eb-9e01-9a2ae7eef0fe.png)

