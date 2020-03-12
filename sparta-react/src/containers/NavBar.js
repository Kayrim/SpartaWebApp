import React from 'react'
import {Navbar, NavDropdown, Form,FormControl,Button } from 'react-bootstrap'

function Nav(){
    return (
      <div>
          <Navbar bg="dark" expand="lg" >
              <Navbar.Brand color="white" > Sparta App</Navbar.Brand>
              <NavDropdown title="API"> 
              <NavDropdown.Item onClick=""> Students </NavDropdown.Item>
              
               </NavDropdown>

          </Navbar>
      </div>
    )
};

export default Nav;