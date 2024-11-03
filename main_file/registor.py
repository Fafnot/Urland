from PyQt6.QtWidgets import QApplication, QWidget, QLineEdit, QPushButton, QTextEdit, QVBoxLayout
import sys
from PyQt6 import QtGui
import os


class App(QWidget):
    def __init__(self):
        super().__init__()

        self.setWindowTitle("Registor Window")
        self.setFixedSize(300, 500)  # width, height
        self.setWindowIcon(QtGui.QIcon('files/static/images/ico_html.ico'))

        # layout Widget
        layout = QVBoxLayout()
        self.setLayout(layout)

        # add button
        self.inputuser = QLineEdit()
        self.output = QTextEdit()
        self.inputPassword = QLineEdit()
        button = QPushButton('Enter', clicked=self.loading_user)
        button_main_bat = QPushButton('info_new_user', clicked=self.bat_file)

        layout.addWidget(self.inputuser)
        layout.addWidget(self.inputPassword)
        layout.addWidget(button)
        layout.addWidget(self.output)
        layout.addWidget(button_main_bat)

    def bat_file(self):
        os.system('start cmd /k "winow_userr_now.bat"')

    def loading_user(self):

        #  registor users and password
        user_save = ["admin", "user"]

        user_save_password = ["admin", "user"]

        #  serch password and user
        input_ueer = self.inputuser.text()

        input_password = self.inputPassword.text()

        # if and else examination on false or true
        if input_ueer == user_save[0]:
            if input_password == user_save_password[0]:
                self.output.setText("yes")
                os.system('start cmd /k "main.bat')
            else:
                self.output.setText("idi naxyi")
        elif input_ueer == user_save[1]:
            if  input_password == user_save_password[1]:
                self.output.setText("on")
                os.system('start cmd /k "user.bat"')
            else:
                self.output.setText("not work")
        else:
            self.output.setText("no i don't now")


if __name__ == "__main__":  # serch main file and run
    app = QApplication(sys.argv)

    window = App()
    window.show()

    app.exec()


















