import { Component, OnInit } from '@angular/core';
import { FinancialService } from '../services/financial.service';

@Component({
  selector: 'app-charts',
  templateUrl: './charts.component.html',
  styleUrls: ['./charts.component.scss']
})
export class ChartsComponent implements OnInit {
  public financialBoxOfficeRevenue: any = null;
  public financialGlobalElectricityDemand: any = null;

  constructor(
    private financialService: FinancialService,
  ) {}

  ngOnInit() {
    // depending on implementation, data subscriptions might need to be unsubbed later
    this.financialService.getData('Box Office Revenue').subscribe(data => this.financialBoxOfficeRevenue = data);
    this.financialService.getData('Global Electricity Demand').subscribe(data => this.financialGlobalElectricityDemand = data);
  }
}
