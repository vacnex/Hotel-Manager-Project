![Verion Status](https://img.shields.io/badge/version-1.0.0-orange) ![Platform](https://img.shields.io/badge/platform-Windows-lightgrey) ![Code type](https://img.shields.io/badge/C%23-.Net%204.8-green) ![](https://img.shields.io/badge/repo%20status-WIP-yellowgreen)
<br />
<p align="center">
  <a href="">
    <img src="https://avatars2.githubusercontent.com/u/17383395" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">HOTEL MANAGER DEMO</h3>

  <p align="center">
    A small fuck-stack projects!
</p>
</p>

## NỘI DUNG

* [Thông Tin Đề Tài](#thông-tin-đề-tài)
  * [Built With](#built-with)
* [Bắt Đầu](#bắt-đầu)
  * [Chuẩn Bị](#chuẩn-bị)
  * [Cài Đặt](#cài-đặt)
* [Sử Dụng](#sử-dụng)
* [Nguồn Hỗ Trợ](#nguồn-hỗ-trợ)

## Thông Tin Đề Tài


<img src="https://i.ibb.co/txqRdY4/web-screen.png" alt="web-screen" border="0" />
<img src="https://i.ibb.co/F3BkXyg/softlogin.png" alt="softlogin" border="0" />

Đề tài quản lý khách sạn sử dụng Web API, bao gồm Web Application và Destop Application

### Built With
* [Bootstrap](https://getbootstrap.com)
* [JQuery](https://jquery.com)
* [Web API](https://docs.microsoft.com/en-us/aspnet/web-api/)
* [WPF](https://docs.microsoft.com/en-us/dotnet/framework/wpf/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [SQL Server Manager 2008 r2](https://www.microsoft.com/en-us/download/details.aspx?id=30438)

## Bắt Đầu

Để có thể cài đặt và sử dụng hãy làm theo hương dẫn bên dưới

### Chuẩn Bị
* [Visual Studio 2019]()
* [Visual Code]() (Tuỳ chọn)
* [SQL Sever Manager 2008 R2]()

### Cài Đặt

1. Clone the repo
```sh
git clone https://github.com/vacnex/Hotel-Manager-Project.git
```
2. Tạo Database
```sh
Excute DB.sql
```
3. Cập nhật các gói Nuget đi kèm trong project
```sh
HotelManager
HotelManagerAPI
```
4. Đổi chuỗi kết nối trong `web.config` và `app.config` trong `HotelManagerAPI`
```xml
  <connectionStrings>
    <add name="HotelManagerDBContext" connectionString="..." />
  </connectionStrings>
```
5. Đổi API url trong `MainWindow.xaml` của `HotelManager`
```C#
string URL_NAME = 'Nhập API Link';
```
6. Đổi API url trong `ajax.js` của `Booking`
```Js
$.getJSON("")
$.post('', JSON.parse(...),"json")
$.ajax({
          url: ''+...,
          ...
      });
```
7. Khởi chạy `HotelManagerAPI` lên `localhost` </br>
Mở Swagger để test api
``
https://localhost:xxx/swagger/
``

## Sử Dụng

1. Desktop Application
```
Có thể dùng project HotelManager hoặc QuanLyThuePhong để test
```
2. Web Front-End
```
Dùng Visual Code mở live server để test
```

## Nguồn Hỗ Trợ
* [Bootstrap Document](https://getbootstrap.com/docs/4.5/getting-started/introduction/)
* [JQuery Document](https://api.jquery.com/)
* [Stackoverflow](stackoverflow.com)
* [Font Awesome](https://fontawesome.com)
* [HandyControls](https://ghost1372.github.io/handycontrol/)
