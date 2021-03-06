import React from "react";
import Spinner from 'react-bootstrap/Spinner'
import NavBar from './NavBar'

class App extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      students: [],
      isLoaded: false
    };
  }

  /**
   * componentDidMount
   *
   * Fetch json array of objects from given url and update state.
   */
  componentDidMount() {
    fetch("http://localhost:61902/api/students")
      .then(res => res.json())
      .then(json => {
        this.setState({
          students: json,
          isLoaded: true
        });
      })
      .catch(err => {
        console.log(err);
      });
  }

  /**
   * render
   *
   * Render UI
   */
  render() {
    const { isLoaded, students } = this.state;

    if (!isLoaded) return <Spinner animation="border" role="status">
    <span className="sr-only">Loading...</span>
  </Spinner>;

    return (
      <div className="App">
        {students.map( item => <li id={item.studentId}>{item.firstName}</li>)}
      </div>
    );
  }
}

export default App;
