var express = require("express");
var request = require("request");
var mustacheExpress = require("mustache-express");
var os = require("os");

var app = express();
app.set("view engine", "html");
app.engine("html", mustacheExpress());
app.set("views", __dirname);

app.get("/", function(req, res){
    res.status(200).send("Pets Demo Aplication.");
});

app.get("/pet", function(req, res){
    var hostname = os.hostname();
    getPet(function(url){
        res.render("index", {
            url: url,
            hostname: hostname
        });
    });
});

var getPet = function(callback){
    request.get("http://api:5000/api/pet", function(err, res, body){
        url = JSON.parse(body).url;
        callback(url);
    });
}

app.listen(3000, "0.0.0.0");

console.log("UI is listening at 0.0.0.0:3000");
