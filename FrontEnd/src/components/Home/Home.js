import Container from "react-bootstrap/Container";
import Nav from "react-bootstrap/Nav";
import { Navbar, Card } from "react-bootstrap";
import { Link } from "react-router-dom";
import classes from "./styles.module.css";
import "bootstrap/dist/css/bootstrap.min.css";
import { Fragment } from "react";

const Home = (props) => {
  return (
    //Navbar
    <Fragment>
      <Navbar bg="dark" variant="dark">
        <Container>
          <Navbar.Brand href="/">
            <img
              src="/logo192.png"
              width="30"
              height="30"
              className="d-inline-block align-top"
              alt="React Bootstrap logo"
            />
            {' '}
            Integration Project
          </Navbar.Brand>
          <Nav className="justify-content-center">
            <Fragment>
              <Nav.Link>
                <Link className="nav-link" to="/home">
                  Home
                </Link>
              </Nav.Link>

              <Nav.Link>
                <Link className="nav-link" to="/user">
                  Users
                </Link>
              </Nav.Link>
              <Nav.Link>
                <Link className="nav-link" to="/item">
                  Items
                </Link>
              </Nav.Link>
            </Fragment>
          </Nav>
        </Container>
      </Navbar>
    </Fragment>
    //Navbar
  );
};

export default Home;
