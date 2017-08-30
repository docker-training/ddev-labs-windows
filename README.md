# Docker for Enterprise Developers
### using Windows Containers

This repository contains the seed for all the labs/exercises executed during the Docker for Enterprise Developers (DDEV) workshop. Most of the exercises are base on a sample application that consists of 3 services

* a Microsoft SQL Server Express database
* a ASP.NET Core Web API
* a Node JS based UI

Each service runs in its own container.

## Running the Sample Application

1. Clone this repo to a local folder, e.g.:

  ```
  PS> cd ~
  PS> git clone -b 17.06 https://github.com/docker-training/ddev-labs-windows.git
  PS> cd ddev-labs-windows/workshop-sample-app
  ```
  
2. Run the application:

  ```
  PS> docker-compose up
  ```
  
3. Open a browser at the correct URL:

  ```
  PS> $ip = docker inspect  --format '{{ .NetworkSettings.Networks.nat.IPAddress }}' workshopsampleapp_ui_1
  PS> start "http://${ip}:3000/pet"
  ```

  you should see a cat GIF.
  
4. Refresh the browser a few times to see other funny GIFs.

5. Also try the API directly using `Invoke-WebRequest` or `curl`, e.g.:

  ```
  PS> $ip = docker inspect  --format '{{ .NetworkSettings.Networks.nat.IPAddress }}' workshopsampleapp_api_1
  PS> (iwr "http://$ip:5000/api/pet").content
  PS> # or  
  PS> (iwr "http://$ip:5000/api/images").content
  PS> # or
  PS> (iwr "http://$ip:5000/api/images/5").content
  ```
  
