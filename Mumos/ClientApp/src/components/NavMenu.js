import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import { LoginMenu } from './api-authorization/LoginMenu';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    render() {
        return (
            <header>
                <div className="navigation w-100">
                    <div className="container">
                        <nav className="navbar navbar-expand-lg navbar-light p-0">
                            <a className="navbar-brand" href="index.html">
                                <img src="images/logo.png" alt="logo" />
                            </a>
                            <button
                                className="navbar-toggler rounded-0"
                                type="button"
                                data-toggle="collapse"
                                data-target="#navigation"
                                aria-controls="navigation"
                                aria-expanded="false"
                                aria-label="Toggle navigation"
                            >
                                <span className="navbar-toggler-icon" />
                            </button>
                            <div className="collapse navbar-collapse" id="navigation">

                                <ul className="navbar-nav ml-auto text-center">
                                    <NavItem className="nav-item active">
                                        <NavLink tag={Link} className="nav-link" to="/">
                                            Home
                                        </NavLink>
                                    </NavItem>
                                    <NavItem className="nav-item @@about">
                                        <NavLink tag={Link} className="nav-link" to="/data">
                                            Data
                                        </NavLink>
                                    </NavItem>
                                    <NavItem className="nav-item @@courses">
                                        <NavLink tag={Link} className="nav-link" to="/counter">
                                            Counter
                                        </NavLink>
                                    </NavItem>
                                    <NavItem className="nav-item @@events">
                                        <NavLink tag={Link} className="nav-link" to="/fetchdata">
                                            FetchData
                                        </NavLink>
                                    </NavItem>
                                    <LoginMenu>
                                    </LoginMenu> 
                                    </ul>
                            </div>
                        </nav>
                    </div>
                    </div>
            </header>
                );
    }
}
