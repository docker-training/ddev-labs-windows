const request = require('supertest');
const sut = require('../src/server.js');

describe("when navigating to about page", function(){
    it("should display title", function(done){
        request(sut.app)
            .get('/about')
            .expect('Content-Type', /html/)
            .expect(/UI for Pets Application/)
            .expect(200,done);
    });
});
