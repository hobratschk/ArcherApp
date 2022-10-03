import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { IArcherForm } from 'src/app/_models/archerForm';
import { ArchersService } from 'src/app/_services/archers.service';

@Component({
  selector: 'app-add-archer',
  templateUrl: './add-archer.component.html',
  styleUrls: ['./add-archer.component.css']
})
export class AddArcherComponent implements OnInit {
  archer: IArcherForm;

  constructor(private archersService: ArchersService, private router: Router, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.loadArcher();
  }

  loadArcher() {
    this.archer = {
      firstName: '',
      lastName: ''
    }
  }

  createArcher(archer: IArcherForm){
    this.archersService.createArcher(archer).subscribe(() => {
      this.router.navigateByUrl('/')
      this.toastr.success('Archer created successfully.')
    });
  }

}
