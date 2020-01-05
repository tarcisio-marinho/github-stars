const mongoose = require("mongoose");
const Repository = require("./repository");
const connection = "mongodb://localhost:27017/github";
const connectDb = () => {
 return mongoose.connect(connection);
};
module.exports = connectDb;
