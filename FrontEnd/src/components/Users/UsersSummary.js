import { Container, Row } from "react-bootstrap";
import Table from "react-bootstrap/Table";
import classes from "./users.module.css";

const DUMMY_USERS = [
  {
    id: 1,
    name: "Elvira",
    email: "efragalaureano@deloitte.com",
    phone: 4427127244,
  },
  {
    id: 2,
    name: "Mark",
    email: "mark@hotmail.com",
    phone: 2367812789,
  },
  {
    id: 3,
    name: "Chris",
    email: "chrish@yahoo.com",
    phone: 3681293467,
  },
  {
    id: 4,
    name: "Liam",
    email: "liambarry@outlook.com",
    phone: 3451026781,
  },
  {
    id: 5,
    name: "Kristine",
    email: "KristineShwarz@hotmail.com",
    phone: 5561289327,
  },
];
const UsersSummary = () => {
  return (
    <>
      <h2>Prueba</h2>
      <br />
      <Container>
        <Row className="mx-auto justify-content-center w-100">
          <Table striped bordered hover className={classes.table}>
            <thead>
                <tr className={classes.tr}>
                <th className={classes.th}>ID</th>
                <th className={classes.th}>Name</th>
                <th className={classes.th}>E-mail</th>
                <th className={classes.th}>Phone</th>
              </tr>
            </thead>
            {DUMMY_USERS.map((users) => {
              return (
                <tbody>
                  <tr>
                    <td className={classes.td}>{users.id}</td>
                    <td className={classes.td}>{users.name}</td>
                    <td className={classes.td}>{users.email}</td>
                    <td className={classes.td}>{users.phone}</td>
                  </tr>
                </tbody>
              );
            })}
          </Table>
        </Row>
      </Container>
    </>
  );
};

export default UsersSummary;
